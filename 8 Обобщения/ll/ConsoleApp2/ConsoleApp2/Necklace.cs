using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Necklace 
    {
        public string date = DateTime.Now.ToString();
        public void PrintDate()
        {
            Console.WriteLine("Дата покупки: {0}", date);
        }

        public PrecioiusStone[] an;
        public int count = 0;
        public int size;
        public int curSize { get; private set; }

        public Necklace()
        {
            size = 5;
            an = new PrecioiusStone[6];
            curSize = 0;
        }

        public bool isFull()
        {
            return (count == size);
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public void Add(PrecioiusStone el)
        {
            if (isFull())
                throw new ExceptionFull("Necklace is full");
            an[count++] = el;

        }

        public void Del(PrecioiusStone el)
        {
            int num = 0;
            if (isEmpty())
                throw new ExceptionFull("Necklace is Empty");
            for (int i = 0; i < count; i++)
            {
                if (an[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                an[i] = an[i + 1];
            }
            count--;
        }

        public void show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(an[i].ToString());
            }
            Console.WriteLine();
        }
    
    }
}
