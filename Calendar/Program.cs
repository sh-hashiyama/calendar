using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year);
            Console.WriteLine("Su Mo Tu We Th Fr Sa");

            var current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // 今月初日を出力する位置が曜日に合うように調整
            for (var i = 0; i < (int)current.DayOfWeek; i++)
            {
                Console.Write("   ");
            }

            while (current.Month == DateTime.Now.Month)
            {
                Console.Write("{0, 2}", current.Day);

                // 出力した日付が土曜日なら改行、それ以外ならスペースを出力する
                if (current.DayOfWeek == DayOfWeek.Saturday)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }

                current = current.AddDays(1);
            }
        }
    }
}
