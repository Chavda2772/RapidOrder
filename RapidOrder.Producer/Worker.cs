using RapidOrder.Common;
using RapidOrder.Common.RabbitMQ;

namespace RapidOrder.Producer
{
    public class Worker : AbstractWorker
    {
        private readonly ILogger<Worker> _logger;
        private readonly RabbitMqHelper _rabbitMqHelper;

        public Worker(ILogger<Worker> logger, RabbitMqHelper rabbitMqHelper)
        {
            _logger = logger;
            _rabbitMqHelper = rabbitMqHelper;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    string message = $"Worker running at: {DateTimeOffset.Now}";
                    _rabbitMqHelper.ProducerMessage(message);
                    _logger.LogInformation(message);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
