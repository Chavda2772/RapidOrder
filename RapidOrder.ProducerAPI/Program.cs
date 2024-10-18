
using RapidOrder.Common.Database;
using RapidOrder.Common.DTO;
using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.ProducerAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<Producer>();
            builder.Services.AddSingleton<IDbHelper>((service) =>
            {
                DbConfig config = new DbConfig()
                {
                    DbType = Common.AllEnums.dbType.MySql,
                    ConnectionString = builder.Configuration.GetConnectionString("DefaultConfiguration")
                };
                return Database.GetDbContext(config);
            });

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
