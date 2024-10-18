using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.RabbitMQ
{
    public class Producer
    {
        public Producer() { }

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

        public bool SendMessage(string message)
        {
            string queueName = "test_queue";
            string exchangeName = "ChangeExchange";
            string exchangeKey = "MaheshExchange_key";

            try
            {
                // Creating connection object
                IConnection connection = GetConnection();
                IModel model = connection.CreateModel();

                // Create Exchange
                model.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Direct);

                // Bind queue to exchange
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

                // Preare config for sending message
                IBasicProperties properties = model.CreateBasicProperties();
                properties.Persistent = false;

                // Send message                
                byte[] messageBuffer = Encoding.Default.GetBytes($"Message: '{message}'");

                // Send message
                model.BasicPublish(
                    exchange: exchangeName,
                    routingKey: exchangeKey,
                    basicProperties: properties,
                    body: messageBuffer);

                Console.WriteLine($"Message sended");

                // Close server connection
                model.Close();
                connection.Close();
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
