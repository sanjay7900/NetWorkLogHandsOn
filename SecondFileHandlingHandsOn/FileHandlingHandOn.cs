using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecondFileHandlingHandsOn
{
    public class FileHandlingHandOn
    {
        public void ReadNetworkLogFile()
        {
            FileStream OpenFile=new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SecondFileHandlingHandsOn\network.txt", FileMode.Open,FileAccess.Read);
            StreamReader Reader=new StreamReader(OpenFile);
            Console.WriteLine("Id"+"\t"+"Source"+"\t\t"+"Destination"+"\t"+"Date\t\t"+"Time\t\t"+ "Status"+"\t"+"Network");
            //Reader.ReadLine();

            while (Reader.Peek() > 0)
            {
                string line = Reader.ReadLine();
                if (line != "")
                {
                    string[] networkdata = line.Split(':');
                    if(networkdata.Length > 3)
                    {
                        
                        string[] mydateTime=networkdata[1].Split(' ');
                        Console.Write(mydateTime[0]+"\t"+mydateTime[1]+":"+networkdata[2]+":"+networkdata[3]+"\t");

                    }
                    else { 
                    Console.Write(networkdata[1]+"\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
