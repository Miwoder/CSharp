using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void Count()
        {
            Console.WriteLine("Поток: ");
            int n = 10;
            for (int i = 1; i < n; i++)
            {
                    Console.WriteLine(i);
                    Thread.Sleep(400);
            }
        }

        public static void Chet()
        {
            
            int n = 10;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {Console.WriteLine("Поток 1: ");
                    Console.WriteLine(i);
                    Thread.Sleep(400);
                }
            }
        }

        public static void NeChet()
        {
            
            int n = 10;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {Console.WriteLine("Поток 2: ");
                    Console.WriteLine(i);
                    Thread.Sleep(390);
                }
            }
        }

        public static void Time(object obj)
        {
                Console.WriteLine("Timer...");
        }

        static void Main(string[] args)
        {
            Process[] proc = Process.GetProcesses();
            foreach (Process process in proc)
            {
                Console.WriteLine($"ID: {process.Id}" +
                    $" Name: {process.ProcessName}  " +
                    $"Priority: {process.BasePriority} ");
                //    $" Started time: {process.StartTime} ");
                //    $" Time: {process.TotalProcessorTime}");
            }
            Console.WriteLine();

            Console.WriteLine("Домен");
            AppDomain domain = AppDomain.CurrentDomain;
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name + "    "+ domain.FriendlyName);
            Console.WriteLine();


            Console.WriteLine("Thread");
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();
            Thread.Sleep(2000);
            Console.WriteLine(myThread.Name + "  " +
                            myThread.Priority + "   " +
                            myThread.ManagedThreadId);
            myThread.Abort();
            Console.WriteLine();

            Console.WriteLine("4");
            Console.WriteLine();
            Thread myThread1 = new Thread(new ThreadStart(Chet));
            Thread myThread2 = new Thread(new ThreadStart(NeChet));
            myThread1.Priority = ThreadPriority.AboveNormal;
            myThread2.Start();
            myThread1.Start();



            TimerCallback tm = new TimerCallback(Time); 
            Timer timer = new Timer(tm, 0, 7000, 2000);

            Console.ReadKey();
        }
    }
}
