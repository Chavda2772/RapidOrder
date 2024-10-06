using RapidOrder.Common.Database.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.Database
{
    internal class MssqlDB : DbHelper
    {
        public MssqlDB() { }

        // Methods
        public string GetDatabaseConnection()
        {
            return "Server=CHAVDAMACHINE\\Mahesh Chavda;Database=RapidOrder;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

        public string GetProductList()
        {
            throw new NotImplementedException();
        }
    }
}
