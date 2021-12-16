using System;

namespace _2_7_Zad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program pobierze 3 liczby i sprawdzi, która jest największa.");
            Console.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int firstNumber);

            Console.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int secondNumber);

            Console.Write("Podaj trzecią liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int thirdNumber);

            if ((firstNumber > secondNumber && firstNumber > thirdNumber) || (firstNumber == secondNumber && firstNumber > thirdNumber))
            {
                Console.WriteLine($"{firstNumber} jest największa z podanych.");
            }
            else if ((secondNumber > firstNumber && secondNumber > thirdNumber) || (secondNumber == thirdNumber && secondNumber > firstNumber))
            {
                Console.WriteLine($"{secondNumber} jest największa z podanych.");
            }
            else if ((thirdNumber > firstNumber && thirdNumber > secondNumber) || (thirdNumber == firstNumber && thirdNumber > secondNumber))
            {
                Console.WriteLine($"{thirdNumber} jest największa z podanych.");
            }
        }
    }
}
