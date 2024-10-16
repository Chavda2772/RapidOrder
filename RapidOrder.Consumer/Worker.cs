using RapidOrder.Common;
using RapidOrder.Common.Database;
using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.Consumer
{
    public class Worker : AbstractWorker
    {
        private readonly ILogger<Worker> _logger;
        private readonly IDbHelper _db;
        private readonly RabbitMqHelper _rabbitMqHelper;
        public Worker(ILogger<Worker> logger, IDbHelper db, RabbitMqHelper rabbitMqHelper)
        {
            _logger = logger;
            _db = db;
            _rabbitMqHelper = rabbitMqHelper;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Consume Rabbit MQ server
            _rabbitMqHelper.ConsumeQueue("Test");

            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _db.AddOrderToCart();
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }

                await Task.Delay(2 * 1000, stoppingToken);
            }
        }
    }
}
