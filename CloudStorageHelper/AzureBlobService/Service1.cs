using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private TransferManager _transferManager;

        protected override void OnStart(string[] args)
        {
            Task transferManager = Task.Factory.StartNew(
            () =>
            {

                _transferManager = new TransferManager(
                    ConfigurationManager.AppSettings["accountName"],
                    ConfigurationManager.AppSettings["accountKey"],
                    ConfigurationManager.AppSettings["rootDir"]
                );

                _transferManager.Start();
            });
        }

        protected override void OnStop()
        {
            _transferManager.Stop();
            _transferManager = null;
        }

        internal void ConsoleStart(string[] args)
        {
            OnStart(args);
        }

        internal void ConsoleStop()
        {
            OnStop();
        }
    }
}
