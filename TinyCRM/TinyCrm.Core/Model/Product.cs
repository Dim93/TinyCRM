using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TinyCrm.Core.Model
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ProductCategory Category { get; set; }

        //public List<OrderProduct> OrderProducts { get; set; }

    }
}
