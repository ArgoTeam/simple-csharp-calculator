using System;
namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            string number;
            number = Console.ReadLine();
            int num;
            num = Convert.ToInt32(number);
            Console.WriteLine(Math.Sqrt(num));
        }
    }
}
