using System;

namespace First
{
    class Program
    {
        static void Main()
        {
        ProgramStart:
            switch (GetMenuKey())
            {
                case 1:
                    WlasnosciLiczby();
                    break;
                case 2:
                    // OcenyZPrzedmiotow();
                    break;
                case 3:
                    // Saper();
                    break;
                case 4:
                    CloseProgram();
                    break;
                default:
                    Console.WriteLine("Wybrany podprogram nie istnieje. Wybierz istniejący element menu.");
                    goto ProgramStart;
            }
        }

        private static void CloseProgram()
        {
            Environment.Exit(0);
        }


        private static void WlasnosciLiczby()
        {
            Liczba number = new Liczba(GetNaturalNumber());

            Console.WriteLine("Postać binarna liczby: {0}", number.ToBin());
            Console.WriteLine("Postać heksadecymalna: {0}", number.ToHex());

            string numberPrimeMessage = "Liczba nie jest liczbą pierwszą.";
            if (number.IsPrime())
                numberPrimeMessage = "Liczba jest liczbą pierwszą.";

            Console.WriteLine(numberPrimeMessage);
        }

        private static void WriteMenuToConsole()
        {
            Console.WriteLine("1. Własności liczby");
            Console.WriteLine("2. Oceny z przedmiotów");
            Console.WriteLine("3. Saper");
            Console.WriteLine("4. Koniec");
        }

        private static void ReadIntFromLine(out int result)
        {
            string userInput;
            do
            {
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out result));
        }

        private static int GetMenuKey()
        {
            WriteMenuToConsole();
            Console.WriteLine("\nWybierz podprogram:");

            ReadIntFromLine(out int key);

            return key;
        }

        private static int GetNaturalNumber()
        {
            Console.WriteLine("Podaj liczbę naturalną, większą od 0:");

            int result = 0;

            while(result < 1)
                ReadIntFromLine(out result);

            return result;
        }
    }
}
