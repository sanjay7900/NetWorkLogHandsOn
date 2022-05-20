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
            Console.WriteLine("Id"+"\t"+"Source"+"\t\t"+"Destination"+"\t"+"Date\t\t"+"Time\t\t"+ "Status"+"\t"+"Network\n");
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
            Reader.Close();
            OpenFile.Close();

        }
       


        public void success()
        {
            FileStream OpenFile = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SecondFileHandlingHandsOn\network.txt", FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(OpenFile);
            Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network\n");
            //Reader.ReadLine();
            string[] usingStatus = new string[6];
            while(Reader.Peek() > 0)
            {
                string line=Reader.ReadLine();
                if(line != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] networkdata = line.Split(':');
                        if (networkdata.Length > 3)
                        {
                            string[] mydateTime = networkdata[1].Split(' ');
                            usingStatus[i] = mydateTime[0];
                            usingStatus[i+1] = mydateTime[1] + ":" + networkdata[2] + ":" + networkdata[3];
                            i++;

                        }
                        else
                        {
                            usingStatus[i] = networkdata[1];


                            if (networkdata[1] == "Success")
                            {
                                Console.Write(usingStatus[0] + "\t" + usingStatus[1] + "\t" + usingStatus[2] + "\t" + usingStatus[3] + "\t" + usingStatus[4] + "\t" + usingStatus[5]+"\t");
                                line =Reader.ReadLine();
                                string[] network = line.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(usingStatus, 0, usingStatus.Length);
                                Console.WriteLine();
                            }
                           
                        }
                        line =Reader.ReadLine();
                       
                    }
                }
                else
                {
                   
                    Array.Clear(usingStatus, 0, usingStatus.Length);

                }

            }


        }
        public void Failed()
        {
            FileStream OpenFile = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SecondFileHandlingHandsOn\network.txt", FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(OpenFile);
            Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network\n");
            //Reader.ReadLine();
            string[] usingStatus = new string[6];
            while (Reader.Peek() > 0)
            {
                string line = Reader.ReadLine();
                if (line != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] networkdata = line.Split(':');
                        if (networkdata.Length > 3)
                        {
                            string[] mydateTime = networkdata[1].Split(' ');
                            usingStatus[i] = mydateTime[0];
                            usingStatus[i + 1] = mydateTime[1] + ":" + networkdata[2] + ":" + networkdata[3];
                            i++;

                        }
                        else
                        {
                            usingStatus[i] = networkdata[1];


                            if (networkdata[1] == "Failed")
                            {
                                Console.Write(usingStatus[0] + "\t" + usingStatus[1] + "\t" + usingStatus[2] + "\t" + usingStatus[3] + "\t" + usingStatus[4] + "\t" + usingStatus[5] + "\t");
                                line = Reader.ReadLine();
                                string[] network = line.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(usingStatus, 0, usingStatus.Length);
                                Console.WriteLine();
                            }

                        }
                        line = Reader.ReadLine();

                    }
                }
                else
                {

                    Array.Clear(usingStatus, 0, usingStatus.Length);

                }

            }


        }
        public void Missed()
        {
            FileStream OpenFile = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SecondFileHandlingHandsOn\network.txt", FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(OpenFile);
            Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network\n");
            //Reader.ReadLine();
            string[] usingStatus = new string[6];
            while (Reader.Peek() > 0)
            {
                string line = Reader.ReadLine();
                if (line != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] networkdata = line.Split(':');
                        if (networkdata.Length > 3)
                        {
                            string[] mydateTime = networkdata[1].Split(' ');
                            usingStatus[i] = mydateTime[0];
                            usingStatus[i + 1] = mydateTime[1] + ":" + networkdata[2] + ":" + networkdata[3];
                            i++;

                        }
                        else
                        {
                            usingStatus[i] = networkdata[1];


                            if (networkdata[1] == "Missed")
                            {
                                Console.Write(usingStatus[0] + "\t" + usingStatus[1] + "\t" + usingStatus[2] + "\t" + usingStatus[3] + "\t" + usingStatus[4] + "\t" + usingStatus[5] + "\t");
                                line = Reader.ReadLine();
                                string[] network = line.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(usingStatus, 0, usingStatus.Length);
                                Console.WriteLine();
                            }

                        }
                        line = Reader.ReadLine();

                    }
                }
                else
                {

                    Array.Clear(usingStatus, 0, usingStatus.Length);

                }

            }


        }
        public void Dailed()
        {
            FileStream OpenFile = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SecondFileHandlingHandsOn\network.txt", FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(OpenFile);
            Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network\n");
            //Reader.ReadLine();
            string[] usingStatus = new string[6];
            while (Reader.Peek() > 0)
            {
                string line = Reader.ReadLine();
                if (line != "")
                {

                    for (int i = 0; i < 6; i++)
                    {
                        string[] networkdata = line.Split(':');
                        if (networkdata.Length > 3)
                        {
                            string[] mydateTime = networkdata[1].Split(' ');
                            usingStatus[i] = mydateTime[0];
                            usingStatus[i + 1] = mydateTime[1] + ":" + networkdata[2] + ":" + networkdata[3];
                            i++;

                        }
                        else
                        {
                            usingStatus[i] = networkdata[1];


                            if (networkdata[1] == "Dialled")
                            {
                                Console.Write(usingStatus[0] + "\t" + usingStatus[1] + "\t" + usingStatus[2] + "\t" + usingStatus[3] + "\t" + usingStatus[4] + "\t" + usingStatus[5] + "\t");
                                line = Reader.ReadLine();
                                string[] network = line.Split(':');
                                Console.Write(network[1]);
                                Array.Clear(usingStatus, 0, usingStatus.Length);
                                Console.WriteLine();
                            }

                        }
                        line = Reader.ReadLine();

                    }
                }
                else
                {

                    Array.Clear(usingStatus, 0, usingStatus.Length);

                }

            }


        }


    }
   
}
