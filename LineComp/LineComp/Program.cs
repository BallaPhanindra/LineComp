using System;

namespace LineComp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=======UC1=========");
            UC1 u1= new UC1();
            u1.length();

            Console.WriteLine("=======UC2=========");
            UC2 u2 = new UC2();
            u2.ComparingLines();
        }
    }
}
