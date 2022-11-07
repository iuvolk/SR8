using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR8_3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string path = @"D:\Temp\Text.txt";
            string[] stringArray;
            string[] textArray;

            int k = 0;
            stringArray = File.ReadAllLines(path);
            for (int i = 0; i < stringArray.Length; i++)
            {
                k++;
            }

            string s = "";
            int l = 0;
            int m = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    s += sr.ReadLine();
                }
                textArray = s.Split(' ');
                l = textArray.Length;
                m = s.Length;
            }

            Console.WriteLine("Количество строк в файле {0}", k);
            Console.WriteLine("Количество слов в файле {0}", l);
            Console.WriteLine("Количество символов в файле {0}", m);
            Console.ReadKey();

        }
    }
}

