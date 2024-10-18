using Microsoft.Extensions.Configuration;
using RapidOrder.Common.Database;
using RapidOrder.Common.DTO;
using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.Consumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((hostContext, services) =>
                {
                    var configuration = hostContext.Configuration;

                    services.AddSingleton<IDbHelper>(serviceProvider =>
                    {
                        var config = new DbConfig()
                        {
                            DbType = Common.AllEnums.dbType.MsSql,
                            ConnectionString = configuration.GetConnectionString("DefaultConnection")
                        };
                        return Database.GetDbContext(config);
                    });
                    services.AddSingleton<RabbitMqHelper>();
                    services.AddHostedService<Worker>();
                });
        }
    }
}