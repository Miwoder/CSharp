using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            GVALog log = new GVALog();
            log.LogHour();
            log.WriteLog("Zapisivaem");
            log.ReadLog();

            GVADiskInfo disk = new GVADiskInfo();
            disk.Info();

            GVAFileInfo file = new GVAFileInfo();
            file.Info();

            GVADirInfo dir = new GVADirInfo();
            dir.Info();
            
            GVAFileManager manager = new GVAFileManager();
            manager.Work();
            



            Console.ReadKey();
        }
    }
}
