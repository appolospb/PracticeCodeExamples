using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel; // Req for WCF service

namespace ScottsServiceHost
{
    // Reference added to 'System.ServiceModel'
    // Reference added to 'ScottsService' local project

    // NOTE! - Visual Studio needs to be 'Run as administrator' otherwise hosting errors will occur

    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ScottsService.ScottsService)))
            {
                host.Open();

                Console.WriteLine(string.Format("Host Started At {0}", DateTime.Now));
                Console.WriteLine("Press ENTER to close the hosting session");

                Console.ReadLine();

                host.Close();
            }
        }
    }
}
