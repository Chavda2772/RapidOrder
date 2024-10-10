using RapidOrder.Common;
using RapidOrder.Common.Database;
using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.Consumer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly Common.RabbitMQ.Consumer _rabbitMqConsumer;
        private readonly IDbHelper _db;

        public Worker(ILogger<Worker> logger, IDbHelper db, Common.RabbitMQ.Consumer consumer)
        {
            _logger = logger;
            _rabbitMqConsumer = consumer;
            _db = db;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Consume message
            _rabbitMqConsumer.ConfigureConsumer();

            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }

                var details = _db.GetProductList();
                Console.WriteLine(details);

                await Task.Delay(10 * 1000, stoppingToken);
            }
        }
    }
}
