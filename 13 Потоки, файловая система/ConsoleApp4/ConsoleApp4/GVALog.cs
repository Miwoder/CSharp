using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp4
{
    class GVALog
    {
        static string path = "VGALogFile.txt";
        public void WriteLog(string text, bool b = true)
        {
            StreamWriter Date = new StreamWriter(path, b);
            Date.WriteLine(DateTime.Now);
            Date.Close();
        }

        public void ReadLog()
        {
            StreamReader rd = new StreamReader(path);
            Console.WriteLine(rd.ReadToEnd());
            rd.Close();
        }


        static public string FindLog(string date)
        {
            string str = " ";
            
            foreach (string s in File.ReadLines(path))
            {
                if (s.Contains(date))
                {
                    str += s;
                    Console.WriteLine();
                }
            }
            //Console.WriteLine(str);
            return str;
        }


        static public void Log()
        {
            int i = 0;
            foreach (string n in File.ReadLines(path))
            {
                i++;
            }
            Console.WriteLine("В файле " + i + " логов");
        }

        public void LogHour()
        {
            Console.WriteLine("");
            string date = DateTime.Now.ToString("dd.MM.yyy") + " Hour: " + DateTime.Now.Hour;
            Console.WriteLine();
            Console.WriteLine(date);

            string last = FindLog(date);
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(last);
            sw.Close();
        }
    }
}
