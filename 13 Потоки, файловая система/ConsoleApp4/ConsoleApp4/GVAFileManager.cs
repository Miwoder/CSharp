using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class GVAFileManager
    {
        public void Work()
        {
            string path = "C:\\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
           
            Console.WriteLine("Подкаталоги:");
            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            

            string newdir = "GVAInspect";
            dirInfo.CreateSubdirectory(newdir);
            string filepath = "GVAdirinfo.txt";
            using (FileStream file1 = File.Create(filepath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("Vvozu novii text v file");
                file1.Write(info, 0, info.Length);
            }


            string newFilePath = "GVAdirinfo2.txt";
            File.Copy(filepath, newFilePath, true);
            File.Delete(filepath);

            string zad2 = "GVAFiles";
            dirInfo.CreateSubdirectory(zad2);
            string filetocopy = "text1.txt";
            string neew = "param.txt";
            FileInfo fileInf = new FileInfo(filetocopy);
            fileInf.CopyTo(neew, true);
        }
    }
}
