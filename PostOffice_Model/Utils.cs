using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice_Model
{
    public static class Utils
    {
        // объект для получения случайных чисел
        public static readonly Random Random = new Random(Environment.TickCount);

        // Получение случайного числа
        // краткая форма записи метода - это не лямбда выражение
        public static int GetRand(int lo, int hi) => Random.Next(lo, hi + 1);
        public static double GetRand(double lo, double hi) => lo + (hi - lo) * Random.NextDouble();
        public static char GetRand(char min = (char)0, char max = (char)255) =>
            (char)Random.Next(min, max + 1);

        // получение случайной даты
        public static DateTime GenRandomDateTime(DateTime from, DateTime to, Random random = null)
        {
            if (from >= to)
            {
                throw new Exception("Параметр \"from\" должен быть меньше параметра \"to\"!");
            }
            if (random == null)
            {
                random = new Random();
            }
            TimeSpan range = to - from;
            var randts = new TimeSpan((long)(random.NextDouble() * range.Ticks));
            return from + randts;
        } // GenRandomDateTime

        // вывести строку в заданную позицию
        public static void WritePos(int left, int top, string str)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(str);
        } // WritePos

        // пример краткой формы записи метода
        public static void SetPos(int left, int top) =>
            Console.SetCursorPosition(left, top);

        // Вычисление наибольшего общего делителя
        public static int Gcd(int a, int b) =>
            b == 0 ? a : Gcd(b, a % b);

        // вывод сообщения о разработке метода
        public static void UnderConstruction()
        {
            SetColor(ConsoleColor.Yellow, ConsoleColor.DarkYellow);

            WritePos(8, 3, "                                   ");
            WritePos(8, 4, "         [К сведению]              ");
            WritePos(8, 5, "                                   ");
            WritePos(8, 6, "         Метод в разработке        ");
            WritePos(8, 7, "                                   ");

            RestoreColor();
            Console.Write("\n\n\n\n\n");
        } // UnderConstruction

        // Установить текущий цвет символов и фона с сохранением
        // текущего цвета символов и фона
        private static (ConsoleColor Fore, ConsoleColor Back) _storeColor;
        public static void SetColor(ConsoleColor fore, ConsoleColor back)
        {
            _storeColor = (Console.ForegroundColor, Console.BackgroundColor);
            Console.ForegroundColor = fore;
            Console.BackgroundColor = back;
        } // SetColor

        // Сохранить цвет
        public static void SaveColor() =>
            _storeColor = (Console.ForegroundColor, Console.BackgroundColor);

        // Восстановить сохраненный цвет
        public static void RestoreColor() =>
            (Console.ForegroundColor, Console.BackgroundColor) = _storeColor;
    } // class Utils
}
