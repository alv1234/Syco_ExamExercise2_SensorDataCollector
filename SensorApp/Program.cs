using SensorApp.SR_ServiceLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SensorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                SensorModel SensorModel = new SensorModel(){ Sensorname = "Sensor" + new Random().Next(1, 100), Id = Guid.NewGuid(), Type = new Random().Next(1, 5), Value = 1.00 };
                WcfServiceDefinitionClient client = new WcfServiceDefinitionClient();
                client.AddSensorData(SensorModel);
                Console.WriteLine(String.Format("New Sensor Data added: {0},{1},{2},{3}", 
                    SensorModel.Sensorname,
                    SensorModel.Id,
                    SensorModel.Type,
                    SensorModel.Value));
                Thread.Sleep(5000);
            }

        }
    }
}
