using System.Linq.Expressions;

namespace HomeTasks_Pro_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Run(Method1);
            Task task2 = Task.Run(Method2);

            for (int i = 0; i < 10; i++)
            {
                Console.Write('*');
                Thread.Sleep(100);
                Console.WriteLine("\nОсновний потік продовжує виконання.");
            }
            Console.WriteLine();
            Console.WriteLine("Основний потік завершив виконання.");
        }

        static void Method1()
        {
            Console.WriteLine("\nMethod1 почав виконання.");
            for (int i = 0; i < 10; i++)
            {
                Console.Write('|');
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Method1 завершив виконання.");
        }

        static void Method2()
        {
            Console.WriteLine("\nMethod2 почав виконання.");
            for (int i = 0; i < 10; i++)
            {
                Console.Write('_');
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Method2 завершив виконання.");
        }
    }
}