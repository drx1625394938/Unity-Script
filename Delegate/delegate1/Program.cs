using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    public delegate int Calc(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();
            Calc calcAdd = calculator.Add;
            int x = 100;
            int y = 200;
            Console.WriteLine(calcAdd(x, y));
            Func<int,int,int> func1 = new Func<int,int,int>(calculator.Sub);
            Console.WriteLine(func1(x,y));
        }
    }
    class Calculator 
    {
        public int Add(int x,int y) 
        {
            int res = x + y;
            return res;
        }

        public int Sub(int x, int y) 
        {
            int res = x - y;
            return res;
        }
    }
}
