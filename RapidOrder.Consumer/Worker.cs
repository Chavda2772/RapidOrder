using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.Consumer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly RapidOrder.Common.RabbitMQ.Consumer _rabbitMqConsumer;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _rabbitMqConsumer = new RapidOrder.Common.RabbitMQ.Consumer();
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

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
