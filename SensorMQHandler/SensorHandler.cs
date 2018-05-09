using DataModel;
using ServiceLayerMQHandler;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorMQHandler
{
    public class SensorHandler
    {
        MQHandler<SensorModel> mq = new MQHandler<SensorModel>(@".\private$\sensorexchange");
        DataProvider dbProvider = new DataProvider();

        public SensorHandler()
        {
            Task.Factory.StartNew(StarReceiving);
        }

        private void StarReceiving()
        {
            while (true)
            {
                var sensorData = mq.ReceiveSensorData();
                dbProvider.InsertSensorsLogs(sensorData.Sensorname, sensorData.Id, sensorData.Type, sensorData.Value);
            }
        }
    }
}
