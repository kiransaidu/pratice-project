using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pratice_project
{
    
    
        public class Program
        {
            static void file1()
            {
                string Path = "D:\\.net\\studentData.txt";
                if (File.Exists(Path))
                {
                    using (StreamReader str = new StreamReader(Path))
                    {
                        string[] line = str.ReadToEnd().Split('\n');
                        foreach (string x in line)
                        {
                            Console.WriteLine(x);
                        }
                    }
                }
                else
            {
                Console.WriteLine("File not found so we create file in same path");
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    sw.WriteLine("Student_Id  : 99");
                    sw.WriteLine("Student_Name  : kiran");
                    sw.WriteLine("Student_Location: Eluru");
                    sw.Close();
                }

                using (StreamReader str2 = new StreamReader(Path))
                {
                    String[] s2 = str2.ReadToEnd().Split('\n');
                    foreach (String x in s2)
                    {
                        Console.WriteLine(x);
                    }
                    str2.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            file1();
        }
    }


}
