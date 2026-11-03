using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }


        public Order(int orderId, string customerName, DateTime orderDate, decimal totalAmount)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }
    }
    public class OrderProcessing
    {
        public static void Main(string[] args)
        {
            //Order order1 = new Order();
            //order1.OrderId = 1;
            //order1.CustomerName = "John Doe";
            //order1.OrderDate = DateTime.Now;
            //order1.TotalAmount = 100.50m;

        }
    }
}
