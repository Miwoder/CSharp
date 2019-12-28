using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class GVAFileInfo
    {
        public void Info()
        {
            string path = "C:\\OOP\\Text\\text1.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Полный путь: " + fileInf.DirectoryName);
                Console.WriteLine("Размер: " + fileInf.Length);
                Console.WriteLine("Расширение: " + fileInf.Extension);
                Console.WriteLine("Имя файла: " + fileInf.Name);
                Console.WriteLine("Время создания: " + fileInf.CreationTime);

            }
            Console.WriteLine();
        }
    }
}
