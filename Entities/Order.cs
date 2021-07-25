using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningEnum.Entities.Enums;

namespace LearningEnum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return 
                "ID: " + this.Id + 
                ", Data: " + this.Moment + 
                ", Status: " + this.Status;
        }
    }
}
