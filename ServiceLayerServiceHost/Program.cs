using ServiceLayerServiceDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfServiceDefinition));
            host.Open();
            Console.WriteLine("Service layer host started");
            Console.ReadLine();
        }
    }
}
