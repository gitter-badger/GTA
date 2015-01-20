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
using System.Timers;

namespace GTA.Windows.Service
{
    partial class GTAService : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        Timer tm = new Timer();

        public GTAService()
        {
            #if DEBUG
                logger.Debug("Service Starting, attaching debugger");
                System.Diagnostics.Debugger.Launch();
            #endif
            InitializeComponent();

            tm.Interval = 5000;
            tm.Elapsed += new ElapsedEventHandler(PerformOperations);
            tm.Start();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            
            logger.Info("Service Started");

        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            logger.Info("Service stopped");
        }

        private void PerformOperations(object sener, EventArgs e)
        {
            logger.Info("I did it!");
        }

    }
}
