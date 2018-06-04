using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            var service = new Service1();
            if (Environment.UserInteractive)
            {
                Console.WriteLine("Starting service...");
                service.ConsoleStart(args);
                Console.WriteLine("Service started. Press 'Enter' to stop!");
                Console.ReadLine();
                Console.WriteLine("Stopping service...");
                service.ConsoleStop();
            }
            else
            {
                ServiceBase.Run(new ServiceBase[] { service });
            }
        }
    }
}
