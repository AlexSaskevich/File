using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLevel
{
    internal class Program
    {
        private void Button_Click(object sender, EventArgs e)
        {
            const int MinRawDataLength = 10;

            if (passportTextbox.Text.Trim() == "")
            {
                int num1 = (int)MessageBox.Show("Введите серию и номер паспорта");
                return;
            }

            string rawData = passportTextbox.Text.Trim().Replace(" ", string.Empty);

            if (rawData.Length < MinRawDataLength)
            {
                textResult.Text = "Неверный формат серии или номера паспорта";
                return;
            }

            string commandText = string.Format("select * from passports where num='{0}' limit 1;", ComputeSha256Hash(rawData));
            string connectionString = string.Format("Data Source=" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\db.sqlite");

            TryFindPassport(connectionString, commandText);
        }

        private void TryFindPassport(string connectionString, string commandText)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(new SQLiteCommand(commandText, connection));
                DataTable dataTable1 = new DataTable();
                DataTable dataTable2 = dataTable1;
                sqLiteDataAdapter.Fill(dataTable2);

                if (dataTable1.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(dataTable1.Rows[0].ItemArray[1]))
                        textResult.Text = "По паспорту «" + passportTextbox.Text + "» доступ к бюллетеню на дистанционном электронном голосовании ПРЕДОСТАВЛЕН";
                    else
                        textResult.Text = "По паспорту «" + passportTextbox.Text + "» доступ к бюллетеню на дистанционном электронном голосовании НЕ ПРЕДОСТАВЛЯЛСЯ";
                }
                else
                    textResult.Text = "Паспорт «" + passportTextbox.Text + "» в списке участников дистанционного голосования НЕ НАЙДЕН";

                connection.Close();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode != 1)
                    return;
                int num2 = (int)MessageBox.Show("Файл db.sqlite не найден. Положите файл в папку вместе с exe.");
            }
        }

        private static object ComputeSha256Hash(string rawData)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            return Convert.ToBase64String(hash);
        }
    }
}