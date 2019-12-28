using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str =
{
                "1op",
                "2 stroka",
                "hfinv"
            };
            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Длинна массива = " + str.Length);

            Console.Write("\nВведите номер элемента: ");
            int Position = Convert.ToInt32(Console.ReadLine());
            Console.Write("Новая строка: ");
            str[Position] = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Строка номер {Position} = {str[Position]}");



            //ступечатый 
            float[][] ArrayFloat = new float[3][];
            ArrayFloat[0] = new float[2];
            ArrayFloat[1] = new float[3];
            ArrayFloat[2] = new float[4];
            Console.WriteLine("Ввод float массива:");

            for (int i = 0; i < ArrayFloat.Length; i++)
            {
                for (int j = 0; j < ArrayFloat[i].Length; j++)
                {
                    ArrayFloat[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            foreach (float[] row in ArrayFloat)
            {
                foreach (float number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

        }
    }
}
