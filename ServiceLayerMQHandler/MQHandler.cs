using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerMQHandler
{
    public class MQHandler<T>
    {
        public MessageQueue Mq { get; set; }
        public string MqName { get; set; }

        public MQHandler(string _mqName)
        {
            MqName = _mqName;
            if (!MessageQueue.Exists(MqName))
            {
                MessageQueue.Create(MqName);
            }

            Mq = new MessageQueue(@"FormatName:direct=os" + MqName);
            Mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
        }

        public T ReceiveSensorData()
        {
            return (T) Mq.Receive().Body;
        }

        public void SendSensorData(T s)
        {
            Mq.Send(s);
        }
    }
}
