using System;
using System.Diagnostics;

namespace FizzBuzz
{
    class Program
    {
        static void Fizz15IterationsMethod(int count)
        {
            // ~10кратное ускорение чем простым перебором
            int i;
            for (i = 1; i < count - 15; i += 15)
            {
                Console.Write($"{i}\n" +
                              $"{i + 1}\n" +
                              "Fizz\n" +
                              $"{i + 3}\n" +
                              "Buzz\n" +
                              "Fizz\n" +
                              $"{i + 6}\n" +
                              $"{i + 7}\n" +
                              "Fizz\n" +
                              "Buzz\n" +
                              $"{i + 10}\n" +
                              "Fizz\n" +
                              $"{i + 12}\n" +
                              $"{i + 13}\n" +
                              "FizzBuzz\n");
            }
            if (i < count)
                FizzCycleMethod(i, count);
        }

        static void FizzCycleMethod(int i, int count)
        {
            // Дорабатываем остаток перебором
            while (i++ <= count)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }

        static void Main()
        {
            var watch = new Stopwatch();
            watch.Start();
            Fizz15IterationsMethod(87);
            watch.Stop();
            Console.WriteLine($"\nFizz timer: {watch.ElapsedMilliseconds}ms");
        }
    }
}
