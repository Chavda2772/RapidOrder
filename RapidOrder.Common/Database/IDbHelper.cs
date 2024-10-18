using RapidOrder.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.Database
{
    public interface IDbHelper
    {
        bool AddOrderToCart();
        List<Product> GetProductList();
    }
}
