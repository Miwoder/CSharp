using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class GVADiskInfo
    {
        public void Info()
        {
            DriveInfo[] info = DriveInfo.GetDrives();

            foreach (DriveInfo drive in info)
            {
                Console.WriteLine("Свободно: " + drive.TotalFreeSpace);
                Console.WriteLine("Имя файл. сист.: " + drive.DriveFormat);
                Console.WriteLine("Имя: " + drive.Name);
                Console.WriteLine("Объем диска: " + drive.TotalSize);
                Console.WriteLine("Метка тома: " +drive.VolumeLabel);
                Console.WriteLine();
            }
        }
    }
}
