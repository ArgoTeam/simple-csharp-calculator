using System;
namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string number1;
            string number2;
            Console.WriteLine("Podaj liczbę 1");
            number1 = Console.ReadLine();
            Console.WriteLine("Podaj liczbę 2");
            number2 = Console.ReadLine();
            float num1;
            float num2;
            num1 = float.Parse(number1);
            num2 = float.Parse(number2);

            float anser = num1 * num2;
            Console.WriteLine(anser);
        }
    }
}
