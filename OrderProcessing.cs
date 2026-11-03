using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    enum OrderOperation
    {
        NewOrder = 1,
        MOdifyOrder = 2,
        DeleteOrder = 3,
        ViewOrder = 4,
        Exit = 5
    }

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
        public static List<Order> orders = new List<Order>();

        public static void Main(string[] args)
        {
            int choice = 0;



            while (true)
            {
                Console.WriteLine("Enter 1 for Adding New Order");
                Console.WriteLine("Enter 2 for Modifying Order");
                Console.WriteLine("Enter 3 for Deleting Order");
                Console.WriteLine("Enter 4 for Viewing Order");
                Console.WriteLine("Enter anything else  for Exit");

                Console.WriteLine("Please enter choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case (int)OrderOperation.NewOrder:
                        Console.WriteLine("Adding New Order");
                        AddNewOrder();
                        break;
                    case (int)OrderOperation.MOdifyOrder:
                        ModifyOrder();
                        Console.WriteLine("Modifying Order");
                        break;
                    case (int)OrderOperation.DeleteOrder:
                        DeleteOrder();
                        Console.WriteLine("Deleting Order");
                        break;
                    case (int)OrderOperation.ViewOrder:
                        ViewOrders();
                        break;

                    default:
                        return;
                }



            }
            //Order order1 = new Order();
            //order1.OrderId = 1;
            //order1.CustomerName = "John Doe";
            //order1.OrderDate = DateTime.Now;
            //order1.TotalAmount = 100.50m;

        }

        private static void DeleteOrder()
        {
            Console.WriteLine("Enter Order Id to modify the other properties");
            int orderId = int.Parse(Console.ReadLine());

            int index = orders.FindIndex(ord => ord.OrderId == orderId);
             
            orders.RemoveAt(index);

        }

        private static void ModifyOrder()
        {
            Order order = new Order(0, "", DateTime.Now, 0);

            Console.WriteLine("Enter Order Id to modify the other properties");
            order.OrderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name");
            order.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Order Date (yyyy-MM-dd)");
            order.OrderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Amount");
            order.TotalAmount = decimal.Parse(Console.ReadLine());

            if (isOrderExists(order.OrderId))
            {
                int index = orders.FindIndex(ord => ord.OrderId == order.OrderId);
                
                orders[index].CustomerName = order.CustomerName;
                orders[index].OrderDate = order.OrderDate;
                orders[index].TotalAmount = order.TotalAmount;

                Console.WriteLine($"{order.OrderId} is updated");
            }
        }

        private static void ViewOrders()
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Customer Name: {order.CustomerName}, Order Date: {order.OrderDate.ToShortDateString()}, Total Amount: {order.TotalAmount}");
            }
        }

        private static void AddNewOrder()
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Enter Order Details");
            Console.WriteLine("****************************************************************");
            Order order = new Order(0, "", DateTime.Now, 0);

            if (order != null)
            {

                Console.WriteLine("Enter Order Id");
                order.OrderId = int.Parse(Console.ReadLine());

                if (order.OrderId > 0 && order.OrderId < int.MaxValue)
                {


                    if (!isOrderExists(order.OrderId))
                    {

                        Console.WriteLine("Enter Customer Name");
                        order.CustomerName = Console.ReadLine();
                        Console.WriteLine("Enter Order Date (yyyy-MM-dd)");
                        order.OrderDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Total Amount");
                        order.TotalAmount = decimal.Parse(Console.ReadLine());

                        orders.Add(order);

                        Console.WriteLine($" {order.OrderId}  is added.");
                    }
                    else
                    {
                        Console.WriteLine($"Order id {order.OrderId} is already Exisits");

                    }
                }
                else
                {
                    Console.WriteLine($"Invalid order id -- {order.OrderId}");
                }
            }


        }

        private static bool isOrderExists(int orderId)
        {
            return orders.Exists(o => o.OrderId == orderId);
        }
    }
}
