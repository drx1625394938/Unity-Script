using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); 
            Waitor waitor = new Waitor();
            customer.Order += waitor.Action;
            customer.Think();

        }
    }
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    public class OrderEventArgs : EventArgs 
    {
        public string DishName { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
    }
    public class Customer 
    {
        public int HaveMoney { get { return this.HaveMoney; } set { this.HaveMoney = 100; } }
        OrderEventHandler orderEventHandler;
        public event OrderEventHandler Order 
        {
            add { this.orderEventHandler += value; }
            remove { this.orderEventHandler -= value; } 
        } 
        public void Think() 
        {
            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kong Pao Chicken";
                e.Size = "large";
                this.orderEventHandler.Invoke(this,e);
            }
        }
    }
    class Waitor
    {
        internal void Action(Customer customer, OrderEventArgs e)
        {
            if (e.Size == "large")
            {
                Console.WriteLine("DishName:{0} DishSize{1} you should pay {2}", e.DishName, e.Size, e.Price * 2);

            }
        }
    }
}
