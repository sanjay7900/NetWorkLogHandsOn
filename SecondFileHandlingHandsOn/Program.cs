using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFileHandlingHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandlingHandOn fileHandlingHandOnObj=new FileHandlingHandOn();
            //fileHandlingHandOnObj.ReadNetworkLogFile();
            fileHandlingHandOnObj.success();
            Console.WriteLine();
            fileHandlingHandOnObj.Failed();
            Console.WriteLine();
            fileHandlingHandOnObj.Missed();
            Console.WriteLine();
            fileHandlingHandOnObj.Dailed();


            Console.ReadKey();
        }
    }
}
