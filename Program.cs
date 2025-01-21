using System;

namespace ReadInt_Function1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enteredNumber;
            string exit = "exit";

            Console.WriteLine($"Введите число для трансфера или введите {exit} длля выхода");

            while (true)
            {
                enteredNumber = RequestNumber();
                GetNumber(enteredNumber);
            }

        }

        static void GetNumber(string enteredNumber)
        {
                int result;
                bool success = int.TryParse(enteredNumber, out result);

                if (success == true)
                    Console.WriteLine($"Переведена '{enteredNumber}' в {result}");
                else
                    Console.WriteLine($"Ошибка {enteredNumber} в числовое значение не переведена");
        }

        static string RequestNumber()
        {
            string enteredNumber;
            Console.WriteLine("Введите числовое значение");
            return enteredNumber = Console.ReadLine();
        }
    }
}
