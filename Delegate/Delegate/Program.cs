using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int Calc(int x, int y);
    public delegate void Print();
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Action action = new Action(calculator.Report);
            action();

            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

            int x = 200;
            int y = 100;
            int z = 0;
            z=func1(x, y);
            Console.WriteLine(z);
            z= func2(x, y);
            Console.WriteLine(z);


            Calc funcAdd = new Calc(calculator.Add);
            Calc funcSub = new Calc(calculator.Sub);

            Console.WriteLine(funcAdd(x, y));
            Console.WriteLine(funcSub(x,y));

            Print funcReport = new Print(calculator.Report);
            funcReport();

           
            ProduceFactory produceFactory = new ProduceFactory();
            WrapFactory wrapFactory = new WrapFactory();
            Func<Product> funcProducePizza = new Func<Product>(produceFactory.ProducePizza);
            Func<Product> funcProduceToy = new Func<Product>(produceFactory.ProduceToy);

            Logger logger = new Logger();
            Action<Product> Log=new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(funcProducePizza,Log);
            Console.WriteLine(box1.Product.Name);
            Box box2= wrapFactory.WrapProduct(funcProduceToy,Log);
            Console.WriteLine(box2.Product.Name);
            

        }
    }
    class Calculator
    {
        public void Report() 
        {
            Console.WriteLine("calculator里的report方法");
        }
       public int Add(int x, int y)
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

    //产品类
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box 
    {
        public Product Product { get; set; }
    }

    //class WrapFactory
    //{
    //    public Box WrapProduct(Product product)
    //    {
    //        Box box = new Box();
    //        //Product product = getProduct.Invoke();
    //        box.Product = product;
    //        return box;
    //    }
    //}
    class Logger 
    {
        public void Log(Product product) 
        {
            Console.WriteLine("产品名称：{0} 产品价格：{1} 创建时间：{2}", product.Name, product.Price, DateTime.UtcNow); ;
        }
    }
    class WrapFactory 
    {
        public Box WrapProduct(Func<Product> getProduct,Action<Product> getLog) 
        {
            Box box = new Box();
            Product product = getProduct();
            if (product.Price > 10) getLog(product);
            box.Product = product;
            return box;
        }
    }
    class ProduceFactory 
    {
        public Product ProducePizza() 
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 5;
            return product;
        }

        public Product ProduceToy()
        {
            Product product = new Product();
            product.Name = "Toy";
            product.Price = 12;
            return product;
        }

    }
}
