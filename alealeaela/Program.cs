namespace dairy
{
    internal class Program
    {
        static void FirstVariation()
        {
            Console.WriteLine("     Вынести мусор");
            Console.WriteLine("     Поиграть в компек");
            Console.WriteLine("     Пойти гулять с костянчиком");
        }
        static void SecondVariation()
        {
            Console.WriteLine("     Побулить женька");
            Console.WriteLine("     Поиграть в компек");
            Console.WriteLine("     Убрать комнату");
        }
        static void ThirdVariation()
        {
            Console.WriteLine("     Адыхаем)");
        }
        static void TaskOne(string data, int pos)
        {
            Console.WriteLine(data);
            Console.WriteLine("~~~~~~~~~~~~~~");

            switch (pos)
            {
                case 1:
                    Console.WriteLine("Выносим мусор :)");
                    break;
                case 2:
                    Console.WriteLine("Включаем компек, запускаем доту, хс, палады, овер..");
                    break;
                case 3:
                    Console.WriteLine("Идём гулять с костянчиком");
                    break;
            }

            Console.WriteLine("~~~~~~~~~~~~~~");
        }
        static void TaskTwo(string data, int pos)
        {
            Console.WriteLine(data);
            Console.WriteLine("~~~~~~~~~~~~~~");

            switch (pos)
            {
                case 1:
                    Console.WriteLine("Просто гениалыч женек.");
                    break;
                case 2:
                    Console.WriteLine("Включаем компек, запускаем доту, хс, палады, овер..");
                    break;
                case 3:
                    Console.WriteLine("Вау, мама ваами гордится");
                    break;
            }

            Console.WriteLine("~~~~~~~~~~~~~~");
        }
        static void Main()
        {
            string data;

            int day = 1;
            int month = 1;
            int year = 2023;

            int pos = 1;

            int variation = 0;

            ConsoleKeyInfo keyInfo;

            do
            {
                if (day <= 0)
                    day = 1;

                if (day > 31)
                {
                    day = 1;
                    month += 1;
                }

                if (month <= 0)
                    month = 1;

                if (month > 12)
                {
                    month = 1;
                    year += 1;
                }

                data = "Сегодня: " + year + "." + month + "." + day;
                Console.WriteLine(data);

                if (day % 2 == 0)
                {
                    variation = 1;
                    FirstVariation();
                }
                else
                {
                    if (day % 3 == 0)
                    {
                        variation = 2;
                        SecondVariation();
                    }
                    else
                    {
                        variation = 3;
                        ThirdVariation();
                    }
                }

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                keyInfo = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    day++;
                    Console.Clear();
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    day--;
                    Console.Clear();
                }

                if (keyInfo.Key == ConsoleKey.UpArrow && pos != 1)
                {
                    Console.Clear();
                    pos--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && pos != 3)
                {
                    Console.Clear();
                    pos++;
                }
                else
                {
                    Console.Clear();
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            if (variation == 1)
                TaskOne(data, pos);
            else if (variation == 2)
                TaskTwo(data, pos);
            else
                Main();
        }
    }
}