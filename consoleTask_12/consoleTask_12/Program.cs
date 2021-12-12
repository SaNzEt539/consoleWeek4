using System;

namespace consoleTask_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                Class1 o = new Class1(int.Parse(Console.ReadLine()));
                Console.WriteLine("Вводите числа через пробел: ");
                o.Input(Console.ReadLine());
                o.Sort();
                Console.WriteLine("Сортированный массив: {0}", o.Show());
                Console.WriteLine("Размер массива: {0}", o.Length);                
                Console.WriteLine("Массив: {0}", o.Show());
                o = o++;
                Console.WriteLine("Массив после ++: {0}", o.Show());
                if (!o)
                {
                    Console.WriteLine("Массив не упорядочен!");
                }
                else
                {
                    Console.WriteLine("Массив упорядочен!");
                }
                Console.Write("Введите скаляр, на который умножить: ");
                o = o * (int.Parse(Console.ReadLine()));
                Console.WriteLine("Массив после *: {0}", o.Show());
                int[] arr = (int[])o;
                o = (Class1)arr;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
