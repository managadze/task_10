using System;

namespace task_10
{
    class Program
    {
        public static void Color(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(txt);
            Console.ResetColor();
        }

        public static void Error(string txt)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(txt);
            Console.ResetColor();
        }
        public static int Enter()
        {
            int el = 0;
            bool ok = true;
            do
            {
                try
                {
                    el = Int32.Parse(Console.ReadLine());
                    ok = true;
                    if (el < 1)
                    {
                        Error("Ошибка, число должно быть больше 0");
                        ok = false;
                    }
                }
                catch
                {
                    ok = false;
                    Error("Ошибка, введите целое число");
                }
            } while (!ok);
            return el;
        }
        static void Main(string[] args)
        {
            List l = new List();
            Color("Введите количество человек");
            int n = Enter();
            l.Create(n);
            Color("Введите номер, который нужно будет удалить");
            int m = Enter();
            Color("Номер оставшегося человека = "+l.Delete(m));
            Console.ReadKey();
        }
    }
}
