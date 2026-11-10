using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Models
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }

        public int Id { get; set; }
    }
}
