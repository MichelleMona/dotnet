using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = DateTime.Now.ToString();
            Console.WriteLine(str);
            orderSystemManager orderSystemManager = new orderSystemManager();
            orderSystemManager.init();
            Order order = orderSystemManager.createOrder();
            Console.WriteLine("随机生成订单,请等待");
            orderSystemManager.orderService.addOrder(order);

            orderSystemManager.createRandomOrders(10);
            Console.WriteLine("输出现在所有的订单：");
            orderSystemManager.orderService.display();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            orderSystemManager.inquiryOrder();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("查询总金额大于500的订单，并按照总金额顺序输出");

            List<Order> orderFindAll = orderSystemManager.orderService.orders.FindAll((Order order1) => { if (order1.totalSum > 500) { return true; } else { return false; } });
            orderFindAll.Sort((Order o1, Order o2) => (int)o1.totalSum - (int)o2.totalSum);
            for (int i = 0; i < orderFindAll.Count; i++)
            {
                Console.WriteLine(orderFindAll[i].ToString());
                Console.WriteLine("\r\n");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}