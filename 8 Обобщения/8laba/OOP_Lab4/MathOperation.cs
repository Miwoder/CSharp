using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    static class MathOperation
    {
        public static int CountOfWords(this string str)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                count += words.Length;
            return count;
        }
    }
}
