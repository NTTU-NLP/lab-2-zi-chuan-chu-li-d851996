using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10311228
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader(@"C:\Users\acer\Desktop\lab-2-zi-chuan-chu-li-d851996\Data\Input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();

                    foreach (var ch in line)
                    {


                        if (ch == '.' || ch == '?' || ch == '!')
                        {
                            Console.WriteLine(ch);

                        }
                        else
                            Console.Write(ch);



                    }

                }


            }
        }
    }
}
