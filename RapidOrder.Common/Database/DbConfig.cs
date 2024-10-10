using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RapidOrder.Common.AllEnums;

namespace RapidOrder.Common.Database
{
    public class DbConfig
    {
        public dbType DbType { get; set; }
        public string ConnectionString { get; set; }
    }
}
