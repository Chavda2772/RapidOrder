using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common.RabbitMQ
{
    public class Producer : Configurarations
    {
        public Producer()
        {
        }

        public void SendMessage(string message)
        {
            var body = Encoding.UTF8.GetBytes(message);
            this._channel.BasicPublish(exchange: "",
                                  routingKey: this.routingKey,
                                  basicProperties: null,
                                  body: body);
            Console.WriteLine(" [X] Sent {0}", message);
        }
    }
}
