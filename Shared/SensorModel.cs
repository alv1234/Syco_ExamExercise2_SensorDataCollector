using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class SensorModel
    {
        public SensorModel(string sensorname, Guid id, int type, double value)
        {
            Sensorname = sensorname;
            Id = id;
            Type = type;
            Value = value;
        }

        public SensorModel()
        {
        }

        public string Sensorname { get; set; }
        public Guid Id { get; set; }
        public int Type { get; set; }
        public double Value { get; set; }

    }
}
