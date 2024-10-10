using RapidOrder.Common.Database.Mongo;
using RapidOrder.Common.Database.Mssql;
using RapidOrder.Common.Database.MySql;
using RapidOrder.Common.Database.Postgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.Database
{
    public class Database
    {
        public static IDbHelper GetDbContext(DbConfig config)
        {
            IDbHelper dbHelper = null;
            switch (config.DbType)
            {
                case AllEnums.dbType.MsSql:
                    dbHelper = new MssqlDB(config);
                    break;
                case AllEnums.dbType.Mongodb:
                    dbHelper = new MongoDB();
                    break;
                case AllEnums.dbType.MySql:
                    dbHelper = new MySqlDB();
                    break;
                case AllEnums.dbType.Postgrace:
                    dbHelper = new PostgreDB();
                    break;
                default:
                    break;
            }

            if (dbHelper == null)
                throw new Exception("Invalid db type");

            return dbHelper;
        }
    }
}
