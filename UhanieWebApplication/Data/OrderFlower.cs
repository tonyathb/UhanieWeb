using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UhanieWebApplication.Data
{
    public class OrderFlower
    {
        public int Id { get; set; }
        public int FlowerId { get; set; }
        public Flower Flower { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
