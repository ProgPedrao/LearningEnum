using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningEnum.Entities;
using LearningEnum.Entities.Enums;

namespace LearningEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendinPayment,
            };
            

            // Forma para fazer a conversão de inteiro para Enum
            string teste = OrderStatus.Processing.ToString();
            
            // 1 Forma de fazer a conversão de string para inteiro
            OrderStatus teste2 = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Processing");

            // 2 Forma de fazer a conversão de string para Enum
            OrderStatus os;
            Enum.TryParse("Processing", out os);


            Console.WriteLine(order);
            Console.WriteLine(teste);
            Console.WriteLine(os);
            Console.WriteLine(teste2);
        }
    }
}
