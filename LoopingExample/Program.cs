using System;
namespace LoopingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loop//
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine("Hello");
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Even Number Using For Loop
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
