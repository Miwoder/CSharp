using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 32;
            long b = 64;
            short c = 16;
            sbyte d = 8;
            Console.WriteLine("Примитивные типы со знаком!");
            Console.WriteLine($"{a}  {b}  {c}  {d}");

            byte e = 8;
            ushort f = 16;
            uint g = 32;
            ulong h = 64;
            Console.WriteLine("Примитивные типы без знака!");
            Console.WriteLine($"{e}  {f}  {g}  {h}");

            float j = 47;
            double k = 816;
            Console.WriteLine("Примитивные типы IEEE-представление с плавающей запятой!");
            Console.WriteLine($"float(4б-точность 7разрядов) {j},  double(8б-16р) {k}");


            bool r = true;
            int sum = 32;
            r = (sum % 3 == 0);
            if (r)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            char daa = 's';
            Console.WriteLine("Примитивные типы символы юникода!");
            Console.WriteLine($"{daa} ");


            Console.WriteLine("Преобразования неявного вида!");
            //1
            int num = 2147483647;
            long bigNum = num;
            //2
            short small = 23432;
            int opq = small;
            //3
            short shot = 8458;
            float lon = shot;
            //4 
            sbyte ne = 127;
            int nr = ne;
            //5
            byte hg = 42;
            ushort ji = hg; 
            Console.WriteLine($"{num}  {bigNum},  {small}  {opq}, {shot}  {lon}, {ne}  {nr}, {hg}  {ji} ");

            Console.WriteLine("Преобразования явного вида!");
            //1
            int aa = 4;
            int bb = 6;
            byte cc = (byte)(aa + bb);
            //2
            short ss = 45;
            byte nn = (byte)ss;
            Console.WriteLine($"{aa}  {bb}  {cc}, {ss}  {nn}");

            Console.WriteLine("Упаковка и распаковка значимых типов!");
            int ii = 123;
            object oo = ii;
            int jj = (int)oo;

            int im = 123;
            object obj = im;
            im = 456;
            System.Console.WriteLine(im);
            System.Console.WriteLine(obj);

            Console.WriteLine("Неявно типизированные переменные!");
            var s1 = 4.0;
            var s2 = 5.0;
            var umn = s1 * s2;
            System.Console.WriteLine($"тип double{ s1}, { s2}, { umn}");

            Console.WriteLine("Переменная Nullable!");
            int? a1 = null;
            int? b1 = a1 ?? 20;

            int? a2 = 10;
            int? b2 = a2 ?? 20;
            Console.WriteLine($"{b1}  {b2}");



            ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("Строки!");
            Console.WriteLine("Объявление и сравнение стоковых литералов");
            string str = "1stroka";
            String.Compare("a", "b"); // вернет -1, т.к. b>a
            Console.WriteLine("1stroka");


            string str1 = "str1";
            string str2 = "str2";
            string str3 = "str3";
            string str4 = "Pishu slova otdelno";
            int startIndex = 3;
            int length = 1;

            string Scepl = str1 + str2;
            string Copy = String.Copy(str1);
            string substring = str1.Substring(startIndex, length);
            string[] words = str4.Split(' ');
            string sert = str4.Insert(5, "HHHH");

            int ind = 2;
            string strr = str4.Remove(ind);

            Console.WriteLine($"{Scepl}  {Copy} {substring} {words} {sert} {strr}");

            string stor1 = "abcd";
            string stor2 = "";
            string stor3 = null;

            Console.WriteLine("String s1 {0}.", Test(stor1));
            Console.WriteLine("String s2 {0}.", Test(stor2));
            Console.WriteLine("String s3 {0}.", Test(stor3));

            String Test(string stor)
            {
                if (String.IsNullOrEmpty(stor))
                    return "null или пустая";
                else
                    return String.Format("(\"{0}\") Не null или пустая", stor);
            }

            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine(sb);
            sb.Remove(6, 4);
            Console.WriteLine(sb);
            sb.Append("!");
            sb.Insert(0, "!");
            Console.WriteLine(sb);
            //////////////////////////////////////////////////////
            //////////////////////////////////////////////////////
            //////////////////////////////////////////////////////
            Console.WriteLine("Массивы");
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int ij = 0; ij < rows; ij++)
            {
                for (int jn = 0; jn < columns; jn++)
                {
                    Console.Write($"{mas[ij, jn]} \t");
                }
                Console.WriteLine();
            }


           

            //int i = 0;
            //int[][] myArr = new int[3][];
            //myArr[0] = new int[2];
            //myArr[1] = new int[3];
            //myArr[2] = new int[4];

            //// Инициализируем ступенчатый массив
            //for (; i < 2; i++)
            //{
            //    int now = Convert.ToInt32(Console.ReadLine());
            //    myArr[0][i] = now;

            //}

            //Console.WriteLine();
            //for (i = 0; i < 3; i++)
            //{
            //    int now = Convert.ToInt32(Console.ReadLine());
            //    myArr[1][i] = now;
            //    Console.Write("{0}\t", myArr[1][i]);
            //}
            //Console.WriteLine();
            //for (i = 0; i < 4; i++)
            //{
            //    int now = Convert.ToInt32(Console.ReadLine());
            //    myArr[2][i] = now;
            //    Console.Write("{0}\t", myArr[2][i]);
            //}

            // неявно типизированные переменные для хранения массива и строки
            var arrayy = new object[0];
            var strk = "";

            // КОРТЕЖИ
            (int count, string, char, string, ulong sum) primer = (21, "Tom", 'A', "Adres", 1221423423423);
            Console.WriteLine(primer);
            Console.WriteLine(primer.count); 
            Console.WriteLine(primer.sum);
            var cortage2 = (int32: 2, str1: "string3", symbol: 's', str2: "string4", Ulong: 2352532);

            (string first, string middle, string last) = ("one", "two", "three");
            Console.WriteLine($"{first}, {middle}, {last}");

            bool Result = primer.Equals(cortage2);
            Console.WriteLine("Равенство кортежей: " + Result);


            

            Console.ReadKey();
        }
    }
}
