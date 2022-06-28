using System;

namespace OnlineStore
{
    internal class Good
    {
        public string Name { get; private set; }

        public Good(string name)
        {
            Name = name;
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }
}
