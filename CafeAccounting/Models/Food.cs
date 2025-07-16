using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAccounting.Models
{
    public class Food
    {
        public string Name { get; set; } = "";
        public string ImagePath { get; set; } = "";
        public double Price { get; set; }
        public string Category { get; set; } = "";
        public int AvailableCount { get; set; }
        public int TotalOrderCount { get; set; }
    }
}
