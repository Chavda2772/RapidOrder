using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RapidOrder.Common.RabbitMQ
{
    public class Consumer
    {
        public IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                UserName = "admin",
                Password = "admin",
                // VirtualHost = "/",
                HostName = "localhost",
                // Port = 5672
            };
            return factory.CreateConnection();
        }

        public bool ConfigureConsumer()
        {
            string queueName = "test_queue";
            string exchangeName = "ChangeExchange";
            string exchangeKey = "MaheshExchange_key";
            string direct_consumeTag = "";

            try
            {
                // Creating connection object
                IConnection connection = GetConnection();
                IModel model = connection.CreateModel();

                // Create Exchange
                model.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Direct);

                // Create queue
                model.QueueDeclare(
                    queue: queueName,
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                // Bind queue to exchange
                model.QueueBind(
                    queue: queueName,
                    exchange: exchangeName,
                    routingKey: exchangeKey
                    );

                model.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
                model.BasicQos(prefetchSize: 0, prefetchCount: 1, global: true);

                EventingBasicConsumer consumer = new EventingBasicConsumer(model);
                consumer.Received += (_model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);

                    Console.WriteLine($"Complete - {queueName}: Message is: {message}");
                    model.BasicAck(ea.DeliveryTag, false);
                };

                model.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
