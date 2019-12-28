using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        class Date
        {
            public string date = DateTime.Now.ToString();
        }

        public interface IObInterface<T>
        {
            void add(T obj);
            T del(T obj);
            void show();

        }
        public static class extensions
        {
            public static int Lastelem(this int queue_1, int tail)
            {
                return tail;
            }
        }

        // Владелец
        public class Owner
        {
            public string ID { get; } = "11111111";
            public string Name { get; } = "Nikita";
            public string Univer { get; } = "BSTU";
        }
        // Дата
        class DATA
        {
            public DateTime info;

        }


        // Очередь
        public class Queue<T> : IObInterface<T> where T : struct
        {
            public T[] dataarr; // данные
            public int head;//голова
            public int tail;// хвост
            int count;
            private static DateTime info;

            public Queue(int numbers)
            {
                dataarr = new T[3];
                head = 0;
                tail = 0;

            }
            public void add(T item)// добавление
            {

                dataarr[tail] = (T)item;
                tail++;
                count++;
            }
            public T del(T a)// извлечение\удаление
            {
                if (count == 0)
                {
                    throw new Exception_size("Очередь пуста. Удаление не возможно");
                }
                a = dataarr[head];
                head++;
                return a;
                count--;
            }
            public void show()// вывод
            {
                foreach (T i in dataarr)
                {
                    Console.WriteLine(i);
                }
            }


            public readonly Owner owner = new Owner();

            // Перегрузка операций
            //////////////////
            public static Queue<T> operator +(Queue<T> q1, T q2)
            {
                q1.add(q2);
                return q1;
            }
            ///////////////////
            public static Queue<T> operator -(Queue<T> q1, T q2)
            {
                q1.del(q2);
                return q1;
            }
            ///////////////////
            public static bool operator true(Queue<T> q1)
            {
                return q1.head == q1.tail;
            }
            ////////////////////
            public static bool operator false(Queue<T> q1)
            {
                return q1.head != q1.tail;
            }
            ////////////////////
            public static Queue<T> operator >(Queue<T> q1, Queue<T> q2)
            {
                for (int i = 0; i < q1.count; i++)
                {
                    q2.dataarr[i] = q1.dataarr[i];
                }
                return q2;
            }
            public static Queue<T> operator <(Queue<T> q1, Queue<T> q2)
            {

                return q2;
            }
            ///////////////
            public int Count { get { return count; } }

            public void Clear()
            {
                head = 0;
                tail = 0;
                count = 0;
            }

        }
        
            static void Main(string[] args)
            {
                try
                {
                    Queue<int> queue_1 = new Queue<int>(3);
                    queue_1.add(4);
                    queue_1.add(7);
                    queue_1 = queue_1 + 2;
                    //Queue<string> queue_2 = new Queue<string>(2);
                    //queue_2.add("first");
                    //queue_2.add("second");
                    //queue_2.show();
                    Queue<bool> queue_3 = new Queue<bool>(2);
                    queue_3.add(true);
                    queue_3.add(false);
                    queue_3.show();
                    // exception_1
                    //queue_1 = queue_1 + 2;

                    Console.WriteLine("Name: " + queue_1.owner.Name);
                    Console.WriteLine("ID: " + queue_1.owner.ID);
                    Console.WriteLine("Univer: " + queue_1.owner.Univer);
                    queue_1.show();
                    // exception_2
                    // queue_1.Clear();
                    // queue_1.del(4);

                }
                catch (Exception_size ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                }
                finally
                {
                    Console.WriteLine("Конец программы");
                }

                //    queue_1.Enqueue(5);
                //    queue_1 = queue_1 + 2;
                //    queue_1 = queue_1 + 1;
                //    Console.WriteLine("Очередь №1");
                //    foreach (int i in queue_1.dataarr)
                //        Console.WriteLine(i);
                //    Console.WriteLine("Очередь №2 до");
                //    foreach (int i in queue_2.dataarr)
                //        Console.WriteLine(i);
                //    queue_2 = queue_1 > queue_2;
                //    Console.WriteLine("Очередь №2 после");
                //    foreach (int i in queue_2.dataarr)
                //        Console.WriteLine(i);
                //    info = DateTime.Now;
                //    Console.WriteLine(info);

            }

        



































        /* static void Main(string[] args)
        {
            Program.Date Date = new Program.Date();
            Console.WriteLine("Дата создания: {0}", Date.date);

            string str = "Hello world";
            Console.WriteLine(str);
            Console.WriteLine(str.WordMinus(6));
            Vektor one = new Vektor(1, 2);
            Vektor two = new Vektor(3, 4);
            Vektor four = new Vektor(2, 2);
            Vektor three = one + two;
            Console.WriteLine(one > two);
            Console.WriteLine(one < two);
            Console.WriteLine(one == two);
            four.DeletePlus();
            Console.WriteLine("Значения x и y:{0} и {1} ", four.x, four.y);
            Console.WriteLine("Значения x и y:{0} и {1}", two.x, two.y);
            Console.WriteLine("Значение x и y:{0} и {1} ", three.x, three.y);
            Vektor vektor = new Vektor();
            vektor.user.GetInfo();
            ////////
            //////////
            ///////////
            IInterface<int> user1 = new Interface<int>(6789);
            Console.WriteLine(user1.Id);    // 6789

            IInterface<string> user2 = new Interface<string>("12345");
            Console.WriteLine(user2.Id);


















            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static string WordMinus(this string str, int c)
        {
            return str.Remove(0, c);

        }
        public static Vektor DeletePlus(this Vektor vektor)
        {
            if (vektor.x > 0)
            {
                vektor.x = 0;
            }
            if (vektor.y > 0)
            {
                vektor.y = 0;
            }
            return vektor;
        }
    }
    public class Vektor
    {

        public Ownew user = new Ownew(15, "Вадим", "БГТУ");

        public int x, y;
        public Vektor()
        {
            x = 0;
            y = 0;
        }
        public Vektor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vektor operator +(Vektor vektor, Vektor vektor1)
        {

            return new Vektor(vektor.x + vektor1.x, vektor.y + vektor1.y);
        }
        public static bool operator >(Vektor vektor, Vektor vektor1)
        {
            if (vektor.x * vektor.y > vektor1.x * vektor.y) return true;
            else return false;
        }
        public static bool operator <(Vektor vektor, Vektor vektor1)
        {
            if (vektor.x * vektor.y < vektor1.x * vektor.y) return true;
            else return false;
        }
        public static Vektor operator ==(Vektor vektor, Vektor vektor1)
        {
            vektor1.x = vektor.x;
            vektor1.y = vektor.y;
            return vektor1;
        }
        public static Vektor operator !=(Vektor vektor, Vektor vektor1)
        {
            vektor1.x = vektor.x;
            vektor1.y = vektor.y;
            return vektor1;

        }
        public static bool operator true(Vektor vektor)
        {
            if (vektor.x == 0 && vektor.y == 0) return true;
            else return false;
        }
        public static bool operator false(Vektor vektor)
        {
            if (vektor.x != 0 && vektor.y != 0) return true;
            else return false;
        }
        public class Ownew
        {
            int Id = 25676;
            string Name = "UUU";
            string UO = "GGGGG";

            public Ownew(int Id, string Name, string UO)
            {
                this.Id = Id;
                this.Name = Name;
                this.UO = UO;
            }
            public void GetInfo()
            {
                Console.WriteLine($"{Id},{Name},{UO}");
            }
            
        }

        */

    }
}
