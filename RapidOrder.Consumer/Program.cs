using RapidOrder.Common.Database;

namespace RapidOrder.Consumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton(t =>
            {
                var config = new DbConfig()
                {
                    DbType = Common.AllEnums.dbType.MsSql,
                    ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                };
                return Database.GetDbContext(config);
            });
            builder.Services.AddSingleton<Common.RabbitMQ.Consumer>();
            builder.Services.AddHostedService<Worker>();

            var host = builder.Build();
            host.Run();
        }
    }
}