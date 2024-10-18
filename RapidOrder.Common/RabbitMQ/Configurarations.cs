using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RapidOrder.Common.RabbitMQ
{
    public abstract class Configurarations
    {
        private readonly IConnection _connection;
        public readonly IModel _model;
        public readonly string queueName = "post-order";
        public readonly string routingKey = "post-order";
        public Configurarations()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "admin"
            };
            _connection = factory.CreateConnection();
            _model = _connection.CreateModel();
            _model.QueueDeclare(queue: queueName,
                                  durable: false,
                                  exclusive: false,
                                  autoDelete: false,
                                  arguments: null);
        }

        public IModel GetConnectionModel() => _model;
    }
}
