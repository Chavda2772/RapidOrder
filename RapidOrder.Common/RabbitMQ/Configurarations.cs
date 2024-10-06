using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RapidOrder.Common.RabbitMQ
{
    public class Configurarations
    {
        private readonly IConnection _connection;
        public readonly IModel _channel;
        public readonly string queueName = "post-order";
        public readonly string routingKey = "post-order";
        public Configurarations()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin"
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: queueName,
                                  durable: false,
                                  exclusive: false,
                                  autoDelete: false,
                                  arguments: null);
        }
    }
}
