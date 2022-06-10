using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }

    }
}
