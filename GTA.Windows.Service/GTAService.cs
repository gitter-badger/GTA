using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using NLog;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Windows.Service
{
    partial class GTAService : ServiceBase
    {
        public GTAService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        private static Logger logger = LogManager.GetCurrentClassLogger();
    }
}
