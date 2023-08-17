using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waitrss waitrss = new Waitrss();
            customer.Order += waitrss.Action;
            customer.Action();
            customer.PayBill();
            
        }
    }
    public delegate void OrderEventHandler(Customer customer,OrderEventArgs e);
    public  class Customer 
    {
        public double Bill { get; set; }
        public void PayBill ()
        {
            Console.WriteLine("it takes bill money{0}",Bill);
        }
        //事件声明
        private OrderEventHandler orderEventHandler;
        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove { this.orderEventHandler -= value; }
        }
        public void WakeIn() 
        {
            Console.WriteLine("walk into the restaurant");
        }
        public void SetDown() 
        {
            Console.WriteLine("set down on the chair");
        }
        public void Think() 
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("let me think");
                Thread.Sleep(1000);
            }
            if (this.orderEventHandler != null) 
            {
                OrderEventArgs e= new OrderEventArgs();
                e.DishName = "gongbao chicken";
                this.Bill=10*2;
                e.Size = "big";
                this.orderEventHandler.Invoke(this,e);
            }
        }
        public void Action() 
        {
            Console.ReadLine();
            this.WakeIn();
            this.SetDown();
            this.Think();
        }
    }
    public class OrderEventArgs :EventArgs
    {
       
        public string DishName;
        public string Size;
    }
    public class Waitrss
    {
        internal void Action(Customer customer, OrderEventArgs e)
        {
            if (e.Size == "big")
                Console.WriteLine(" is serve you the dish {0},price is{1}", e.DishName, 10 * 2);
            else 
            {
                Console.WriteLine(" is serve you the dish {0},price is{1}", e.DishName,10 * 0.5);
            }
        }
    }
}
