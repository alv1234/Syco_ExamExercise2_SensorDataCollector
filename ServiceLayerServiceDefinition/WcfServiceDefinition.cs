using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModel;
using Shared;

namespace ServiceLayerServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfServiceDefinition" in both code and config file together.
    public class WcfServiceDefinition : IWcfServiceDefinition
    {
        public List<SensorModel> sensors = new List<SensorModel>();
        DataProvider dbprovider = new DataProvider();

        public void AddSensorData(SensorModel sensorData)
        {
            var isworking = dbprovider.InsertSensorsLogs(sensorData.Sensorname, sensorData.Id, sensorData.Type, sensorData.Value);
        }

        public List<SensorModel> GetSensorData()
        {
            var result = dbprovider.QuerySensorsLogs();
            foreach (var item in result)
            {
                sensors.Add(new SensorModel() { Sensorname = item.Sensorname, Id = item.Id, Type = item.Type, Value = item.Value});
            }
            return sensors;
        }
    }
}
