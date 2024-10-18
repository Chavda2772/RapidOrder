using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.RabbitMQ
{
    public class RabbitMqHelper
    {
        private readonly Consumer _consumer;
        private readonly Producer _producer;

        public RabbitMqHelper()
        {
            _consumer = new Consumer();
            _producer = new Producer();
        }

        public void ConsumeQueue(string queueName)
        {
            _consumer.ConfigureConsumer();
        }

        public void ProducerMessage(string message)
        {
            _producer.SendMessage(message);
        }
    }
}
