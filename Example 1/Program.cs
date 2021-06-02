using System;

namespace Lambda_Expressions
{
    public delegate string MessageDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            MessageDelegate obj = (name) =>                         //Lambda Expression
            {
                return "Hai " + name;
            };
            string str = obj.Invoke("Rohit");
            Console.WriteLine(str);
        }
    }
}
