using System;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using WcfServiceLibrary;

namespace ConsoleHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serviceType = typeof(BetService);
            var serviceUri = new Uri("http://localhost:8090/");
            var host = new ServiceHost(serviceType, serviceUri);
            host.Open();

            #region Output dispatchers listening

            foreach (var uri in host.BaseAddresses) Console.WriteLine("\t{0}", uri);
            Console.WriteLine();
            Console.WriteLine("Number of dispatchers listening : {0}", host.ChannelDispatchers.Count);
            foreach (ChannelDispatcher dispatcher in host.ChannelDispatchers)
                Console.WriteLine("\t{0}, {1}", dispatcher.Listener.Uri, dispatcher.BindingName);
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate Host");
            Console.ReadLine();

            #endregion

            host.Close();
        }
    }
}