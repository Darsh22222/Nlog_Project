using System.ComponentModel;

namespace NlogDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem\n Enter a & b values");
            Sum Sum = new Sum();
            Console.WriteLine("Result is : " + " " + Sum.add(0, 1));


        }
    }
}