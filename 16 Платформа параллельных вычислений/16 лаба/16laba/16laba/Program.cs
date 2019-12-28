using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace _16laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[,] arr = new int[,] {
                { 1, 1, 0, 0 },
                { 1, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 1, 1 } };
            int[,] arr1 = new int[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 1 },
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 } };
                        





            Task task = new Task(() =>
            {
                int[,] arr2 = Multiplication(arr, arr1);
                Console.WriteLine("Произведение матриц:");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(arr2[i, j]+" ");
                    }
                    Console.WriteLine(" ");
                    
                }

            });
            stopwatch.Start();
            task.Start();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Время выполнения " + ts);
            Console.ReadKey();








            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task task1 = new Task(() =>
            {
                Console.WriteLine();
                for (int i = 0; i <= 100; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    if (i == 12)
                    {
                        cancelTokenSource.Cancel();
                    }
                    Console.Write(i + " ");
                    Thread.Sleep(200);
                }
            });
            task1.Start();
            Console.ReadKey();


            int x = 3;
            Func<int> func = () =>
            {
                return x+x*x;
            };

            Task<int> one = new Task<int>(func);
            Task<int> two = new Task<int>(func);
            Task<int> three = new Task<int>(func);

            one.Start();
            two.Start();
            three.Start();
            Console.WriteLine($"Задача 1 - {one.Result}   Задача 2 - {two.Result}   Задача 3 - {three.Result}");
            Func<int> function = () =>
            {
                return one.Result + two.Result + three.Result;
            };
            Task<int> resultat = new Task<int>(function);
            resultat.Start();
            Console.WriteLine("Результат = " + resultat.Result);
            Console.ReadKey();





            Task firsttask = new Task(() =>
            {
                Console.WriteLine($"Id первой задачи: {Task.CurrentId}");
            });
            
            Task secondtask = firsttask.ContinueWith(Display);
            firsttask.Start();
            secondtask.Wait();

            Task<int> anothertask = Task.Run(() => 50 + 35);
            var awaiter = anothertask.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                Console.WriteLine("Результат: " + awaiter.GetResult());
            });
            Console.ReadKey();

            void Display(Task t)
            {
                Console.WriteLine($"Id второй задачи: {Task.CurrentId}");
                Thread.Sleep(3000);
            }




            stopwatch.Restart();
            Parallel.For(1, 10, Factorial);
            stopwatch.Stop();
            Console.WriteLine("Parallel.For:  " + stopwatch.Elapsed + '\n');

            stopwatch.Restart();
            int number = 1;
            for (int i = 1; i <= 9; i++)
            {
                number *= i;
                Console.WriteLine(number);
            }
            Thread.Sleep(3000);
            stopwatch.Stop();
            Console.WriteLine("For:  " + stopwatch.Elapsed + '\n');
            Console.ReadKey();

            stopwatch.Restart();
            ParallelLoopResult result1 = Parallel.ForEach<int>(new List<int>() { 1,2,3,4,5},
                Factorial);
            stopwatch.Stop();
            Console.WriteLine("Parallel.ForEach:  " + stopwatch.Elapsed + '\n');

            stopwatch.Restart();
            int result2 = 1;
            for (int i = 1; i <= 5; i++)
            {
                result2 *= i;
                Console.WriteLine(result2);
            }
            Thread.Sleep(3000);
            stopwatch.Stop();
            Console.WriteLine("ForEach:  " + stopwatch.Elapsed + '\n');

            void Factorial(int z)
            {
                int result = 1;

                for (int i = 1; i <= z; i++)
                {
                    result *= i;
                }
                Console.WriteLine($" {z} ! = {result}");
                Thread.Sleep(3000);
            }

            Console.ReadKey();

            






            Parallel.Invoke(Show,
        () => {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Thread.Sleep(3000);
        },
        () => Factorial(5));
            Console.ReadKey();

            Console.WriteLine();
            FactorialAsync();


            Console.ReadLine();
           

            void Show()
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Thread.Sleep(3000);
            }

            async void FactorialAsync()
            {
                await Task.Run(() => Factorial(3));
            }


            









            int[,] Multiplication(int[,] a, int[,] b)
            {
                int[,] r = new int[a.Length, b.Length];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        r[i, j] = 0;
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            r[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                return r;
            }
        }
    }
}
