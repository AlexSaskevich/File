namespace MethodName
{
    internal class Program
    {
        private static void Main()
        {
        }

        private static int Clamp(int calue, int min, int max)
        {
            if (calue < min)
                return min;
            else if (calue > max)
                return max;
            else
                return calue;
        }
    }
}