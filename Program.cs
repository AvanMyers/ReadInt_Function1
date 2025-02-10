using System;

namespace ReadInt_Function1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            while (isOpen)
            {
                isOpen = IsRequestNumber();
            }
        }

        static void ReadInt(string enteredNumber)
        {
            int result;
            bool haveSuccess = int.TryParse(enteredNumber, out result);

            if (haveSuccess == true)
                Console.WriteLine($"Переведена '{enteredNumber}' в {result}");
            else
                Console.WriteLine($"Ошибка {enteredNumber} в числовое значение не переведена");
        }

        static bool IsRequestNumber()
        {
            string enteredNumber;
            string exit = "exit";
            bool inWork = true;

            Console.WriteLine($"Введите число для трансфера или введите {exit} длля выхода");

            while (inWork)
            {
                Console.WriteLine("Введите числовое значение");
                enteredNumber = Console.ReadLine();

                if (enteredNumber == exit)
                    inWork = false;
                else
                    ReadInt(enteredNumber);
            }

            return inWork = false;
        }
    }
}
