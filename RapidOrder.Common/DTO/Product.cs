using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.DTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductShortName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DeliveryTimeSpan { get; set; }
        public int CategoryId { get; set; }
        public string ProductImageUrl { get; set; }
        public string CategoryName { get; set; }
    }
}
