using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_线程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //开启新线程
            ThreadStart start = new ThreadStart(ChildThreadMethod);
           Thread childThread=new Thread(start);
            childThread.Start();
            Console.WriteLine("mainThread is running");

        }

        private static void ChildThreadMethod() 
        {
            Console.WriteLine("ChildThread is running!");
        }
    }
}
