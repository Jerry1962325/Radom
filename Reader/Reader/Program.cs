using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reader.MTableAdapters;
using static Reader.M;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Reader
{
    class Program
    {

        static void Main(string[] args)
        {
            
            for(int i=1;i<=250;i++)
            {
                string[] vs = File.ReadAllLines("E:\\豆瓣top250\\" + i + ".txt");
                MoiRea moiRea = new MoiRea();
                moiRea.ADD(vs[1], vs[2].Trim(), vs[3].Trim(), vs[4].Trim(), vs[5].Trim(),vs[7].Trim());
                Console.WriteLine(i + " is OK");
            }
            Console.WriteLine("Everything is OK");
            Console.ReadLine();
        }
    }
}
