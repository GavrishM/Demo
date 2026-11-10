using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Models
{
    public class OrderItem
    {
        public string ProductItem { get; set; }

        public int Count { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
