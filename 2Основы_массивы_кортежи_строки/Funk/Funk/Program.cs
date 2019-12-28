using System;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] ArrayInt32 = { 3, 4, 5, 2, 4, 2, 4 };
            string str = "HELLOW";
            str = MyFunction(ArrayInt32, str, out int max, out int min);
            Console.WriteLine($"Макс: {max}\nМин: {min}\nПервый символ строки: {str} ");

        }
        static string MyFunction(int[] numbers, string str, out int max, out int min)
        {
            min = numbers[0]; int minIndex = 0;
            for (int i = 0; i < numbers.Length - 1; i++) //поиск мин
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            max = numbers[0]; int maxIndex = 0;
            for (int i = 0; i < numbers.Length - 1; i++)//поиск макс
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }
            return str = str.Substring(0, 1);

        }
    }
   
}
