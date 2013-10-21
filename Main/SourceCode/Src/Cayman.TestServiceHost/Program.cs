using BlitsMe.Service.ServiceHost;
using System;
using System.Linq;

namespace Cayman.TestServiceHost
{
    class Program
    {

        static void Main(string[] args)
        {

        }
}

    public partial class BMService : ServiceBase
    {
        public void Start()
        {
                        public const String BuildMarker = "_Dev";
            System.ServiceModel.ServiceHost serviceHost = new System.ServiceModel.ServiceHost(new  Bli, new Uri("net.pipe://localhost/BlitsMeService" + BuildMarker));
            serviceHost.Open();
        }
    }
}




