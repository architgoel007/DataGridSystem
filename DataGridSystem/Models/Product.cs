using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Sales { get; set; }
        public int Categ { get; set; }
        public int SubCateg { get; set; }
    }
}
