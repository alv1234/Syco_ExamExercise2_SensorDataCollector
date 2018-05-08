using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;

namespace ServiceLayerServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfServiceDefinition" in both code and config file together.
    public class WcfServiceDefinition : IWcfServiceDefinition
    {
        public List<SensorModel> sensors = new List<SensorModel>();
        public void AddSensorData(SensorModel sensorData)
        {
            sensors.Add(sensorData);
        }

        public List<SensorModel> GetSensorData()
        {
            return sensors;
        }
    }
}
