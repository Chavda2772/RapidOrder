using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common
{
    internal interface dbHelper
    {
        string GetProductList(string tableName);
    }
}
