using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyList<string> list = new MyList<string>();
                Console.WriteLine("List one:");
                Console.WriteLine("--------------------------");
                list.Add("Ivan");
                list.Add("Andrew");
                list.Add("Natalia");
                list.Add("Victor");
                list.Show();
                Console.WriteLine("--------------------------");

                MyList<string> list1 = new MyList<string>();
                Console.WriteLine("List two");
                Console.WriteLine("--------------------------");
                list1.Add("Alexander");
                list1.Add("Uri");
                list1.Add("Vladimir");
                list1.Add("Sergey");
                list1.Show();
                Console.WriteLine("--------------------------");
                bool cn = (list1 == list);
                Console.WriteLine("Списки равны:" + cn);
                list = list + list1;
                Console.WriteLine("Combined list");
                Console.WriteLine("--------------------------");
                list.Show();
                Console.WriteLine("--------------------------");

                list--;
                list = list + "Andrey";


                MyList<string> list3 = new MyList<string>();

                if (list3)
                    Console.WriteLine("List is empty");

                string abc = "awdg fseol  ajes";
                Console.WriteLine($"Count of words: {abc.CountOfWords()}");




                MyList<Person> list4 = new MyList<Person>();
                Person tom = new Person();
                tom.Name = "Tom";
                tom.Age = 18;
                list4.Add(tom);
            }

            finally { Console.WriteLine("Код без ошибок"); }


            Console.ReadKey();
        }











            class Transaction<T> where T : Person, new()
            {
            string lesson = "тип T обязательно должен быть классом Person или его наследником";
            }

    }
}

