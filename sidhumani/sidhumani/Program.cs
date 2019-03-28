using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sidhumani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
        static void download()
        {
            Thread.Sleep(7000);
            Console.WriteLine("download complete");
        }
    }
}
