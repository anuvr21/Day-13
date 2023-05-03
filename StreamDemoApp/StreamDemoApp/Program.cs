using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemoApp
{
    class WriteAndReader

    {
        static string file = @"D:\UST\Stream\StreamTxt.txt";

        static void Main(string[] args)
        {
            Write();
        }
        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("What is this life, full of care");
            fileStream.WriteLine("We have no time to stand and stare");
            fileStream.Close();
        }
        static void Read()
        {
            StreamReader fileStream = new StreamReader(file);
            string s = null;
            while ((s = fileStream.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            fileStream.Close();
        }
    }
}
