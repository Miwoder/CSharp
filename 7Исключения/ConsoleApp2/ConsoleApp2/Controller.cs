using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class controller
    {
        public int price = 0;
        public int weight = 0;
        public int count = 5;
        public int size;

        public void Weight(Necklace necklake)
        {
            for (int i = 0; i < count; i++)
            {
                if (necklake.an[i].good == "Diamond" )
                {
                    weight += 25;
                    price += 1000;
                }
                else if(necklake.an[i].good == "Ruby")
                {
                    weight += 20;
                    price+= 800;                     
                }
                else if(necklake.an[i].good == "Flint")
                {
                    weight += 10;
                    price += 300;                                    
                }
                else if(necklake.an[i].good == "Emerald")
                {
                    weight += 15;
                    price += 500;                                       
                }
                else if(necklake.an[i].good == "Thread")
                {
                    weight += 5;
                    price += 50;                                 
                }
            
            }
            Console.WriteLine("Вес ожерелья: " + weight + ".Стоимость: " + price);
        }

        public void Sort(Necklace necklake)
        {
            PrecioiusStone temp;
            for (int i = 0; i < necklake.count - 1; i++)
            {

                for (int j = i+1; j < necklake.count; j++)
                {
                    
                    if (necklake.an[i].PRice > necklake.an[j].PRice)
                    {
                        temp = necklake.an[i];
                        necklake.an[i] = necklake.an[j];
                        necklake.an[j] = temp;
                    }   
                }
            }
        }


    }
}
