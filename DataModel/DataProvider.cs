using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DataProvider
    {
        BwiTrainingEntities dbmodel = new BwiTrainingEntities();

        public List<wi16b087_SensorLogs> QuerySensorsLogs()
        {

            var query = from x in dbmodel.wi16b087_SensorLogs
                        select x;
            return query.ToList();
        }

        public bool InsertSensorsLogs(String _sensorname, Guid _id, int _type, double _value)
        {
            try
            {
                wi16b087_SensorLogs newSensorLog = new wi16b087_SensorLogs()
                {
                    Sensorname = _sensorname,
                    Id = _id,
                    Type = _type,
                    Value = _value
                };
                dbmodel.wi16b087_SensorLogs.Add(newSensorLog);
                dbmodel.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
