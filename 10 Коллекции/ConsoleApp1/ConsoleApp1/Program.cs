using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList objectList = new ArrayList() { 132, 222, 100, 1, 2 };
            objectList.Add("stroka");

            var Student = new { name = "Ivan" };
            objectList.Add(Student);

            int m = Convert.ToInt32(Console.ReadLine());
            objectList.RemoveAt(m);

            int counter = 1;
            foreach (var obj in objectList)
            {
                counter += 1;
                Console.WriteLine(obj);
            }
            Console.WriteLine(counter);

            var znach = 222;
            if (objectList.Contains(znach) == true)
            {
                 Console.WriteLine(objectList.IndexOf(znach));
            }

            //////////
            ////////////
            //////////////

            Dictionary<double, string> dictionaryList = new Dictionary<double, string>(6);
            dictionaryList.Add(1.0, "Ivan");
            dictionaryList.Add(2.0, "Misha");
            dictionaryList.Add(3.0, "Pasha");
            dictionaryList.Add(4.0, "Oleg");
            dictionaryList.Add(5.0, "Vlad");
            dictionaryList.Add(6.0, "Igor");
            foreach (KeyValuePair<double, string> keyValue in dictionaryList)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            dictionaryList.Remove(6);
            foreach (KeyValuePair<double, string> keyValue in dictionaryList)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }


            Queue<string> queList = new Queue<string>();
            queList.Enqueue("Ivan");
            queList.Enqueue("Misha");
            queList.Enqueue("Pasha");
            queList.Enqueue("Oleg");
            queList.Enqueue("Vlad");
            foreach (string number in queList)
            {
                Console.WriteLine(number);
            }

            var nznach = "Pasha";
            if (queList.Contains(nznach) == true)
            {
                Console.WriteLine("True");
            }
            Console.WriteLine();

            ///////////
            ///////
            ///
            Product product1 = new Product("Shoker", 200, "Casio");
            Product product2 = new Product("Bomber", 120, "Casio");
            Product product3 = new Product("Oper", 300, "Casio");
            Product product4 = new Product("Koper", 300, "Casio");
            Product product5 = new Product("Audi A6", 2300, "Audi");

            Dictionary<Product , Product> products = new Dictionary<Product, Product>();
            products.Add(product1, product1);
            products.Add(product2, product2);
            products.Add(product3, product3);
            products.Add(product4, product4);
            products.Add(product5, product5);
            foreach (KeyValuePair<Product, Product> keyValue in products)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();

            products.Remove(product5);
            foreach (KeyValuePair<Product, Product> keyValue in products)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();

            ////////////////
            /////////
            ///
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User { Name = "Tolik"},
                new User { Name = "Tema"},
                new User { Name = "Misha"}
            };
            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }
            Console.WriteLine();


            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User { Name = "Alesha" });
            users.RemoveAt(1);
            users[0] = new User { Name = "Andrey" };
            Console.WriteLine();

            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }

            Console.ReadKey();
        }





        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    User newUser = e.NewItems[0] as User;
                    Console.WriteLine($"Добавили: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine($"Удалили: {oldUser.Name}");
                    break;
                
            }
        }
    }
}
