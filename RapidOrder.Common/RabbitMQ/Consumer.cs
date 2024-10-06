using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.RabbitMQ
{
    public class Consumer : Configurarations
    {
        public void ConsumeQueue()
        {
            var consumer = new EventingBasicConsumer(this._channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($"Received message: {message}");
            };
            _channel.BasicConsume(queue: this.queueName, autoAck: true, consumer: consumer);
        }
    }
}
