using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class GVADirInfo
    {
        public void Info()
        {
            string dirName = "C:\\";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(dirName);
            foreach (string n in files)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");

            Console.WriteLine("Подкаталоги:");
            string[] directories = Directory.GetDirectories(dirName);
            foreach (string n in directories)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
          
            Console.WriteLine();
        }
    }
}
