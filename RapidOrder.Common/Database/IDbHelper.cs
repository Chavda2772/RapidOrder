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
        List<Product> GetProductList();
    }
}
