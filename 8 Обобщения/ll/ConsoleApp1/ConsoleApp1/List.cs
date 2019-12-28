using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    
        public class Listt<T> : IInterface<T>
        {
           
            private Listt<T> collection;


           
            public int Size { get; }

           
            public Listt()
            {
                this.collection = new Listt<T>();
            }



            public void Add(T item)
            {
                collection.Add(item);
            }






            public void Del(T item)
            {
                collection.Remove(item);
            }
            virtual public void Show()
            {
                foreach (T item in collection)
                {
                    Console.WriteLine(item);
                }
            }

            public int GetSize()
            {
                int size = 0;
                foreach (T item in collection)
                {
                    size++;
                }
                return size;
            }
            // ПЕРЕГРУЗКИ =================================================
            public static Listt<T> operator +(Listt<T> list, T item)
            {
                list.collection.Add(item);
                return list;
            }

            public static Listt<T> operator +(Listt<T> listOne, Listt<T> listTwo)
            {
                foreach (T item in listTwo.collection)
                {
                    listOne.Add(item);
                }

                return listOne;
            }

            public static Listt<T> operator --(Listt<T> list)
            {
                list.collection.RemoveAt(0);
                return list;
            }


            public static bool operator true(Listt<T> list)
            {
                if (list.GetSize() == 0)
                    return true;
                else return false;
            }

            public static bool operator false(Listt<T> list)
            {
                if (list.GetSize() != 0)
                    return false;
                else return true;
            }
            public class Date
            {
                public readonly DateTime time;

                public Date()
                {
                    time = DateTime.Now;
                }
            }
        }
    
}
