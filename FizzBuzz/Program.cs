using System;
using System.Diagnostics;

namespace FizzBuzz
{
    class Program
    {
        static void Fizz15IterationsMethod(int count)
        {
            for (int i = 1; i < count - 15; i += 15)
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
        }

        static void FizzCycleMethod(int count)
        {
            for (int i = 1; i <= count; i++)
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
            FizzCycleMethod(1000);
            watch.Stop();
            var fizzCycleMethodTimer = watch.ElapsedMilliseconds;
            Console.WriteLine($"Elapsed time {watch.ElapsedMilliseconds}ms");
            Console.WriteLine("Fizz15IterationsMethod\n");
            watch.Restart();
            Fizz15IterationsMethod(1000);
            watch.Stop();
            Console.WriteLine($"\nFizz Cycle Method Time: {fizzCycleMethodTimer}ms");
            Console.WriteLine($"Fizz 15 Iterations Method: {watch.ElapsedMilliseconds}ms");
        }
    }
}
