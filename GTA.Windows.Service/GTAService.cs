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
using GTA.Shared.Components;
//using GTA.Windows.Service.GTAWebService;

namespace GTA.Windows.Service
{
    partial class GTAService : ServiceBase
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //private MetricHandler sendMetric = new MetricHandler();
        Timer tm = new Timer();
        Stopwatch sw = new Stopwatch();

        public GTAService()
        {
            #if DEBUG
                logger.Debug("Service Starting, attaching debugger");
                System.Diagnostics.Debugger.Launch();
            #endif
            sw.Start();
            InitializeComponent();

            tm.Interval = 5000;
            tm.Elapsed += new ElapsedEventHandler(PerformOperations);
            tm.Start();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            sw.Stop();
            logger.Info("Service Started in "+sw.ElapsedMilliseconds.ToString()+" milliseconds");
            sw.Stop();
            //sendMetric.Write_Metric(sw.ElapsedMilliseconds, "GTA.Windows.Service.StartupTime");

        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            logger.Info("Service stopped");
        }

        private void PerformOperations(object sender, EventArgs e)
        {
            logger.Info("I am going to multiply 5 with 6");
            sw.Restart();
            GTAWebService.GTAServiceClient client = new GTAWebService.GTAServiceClient();
            double addResult = client.MultiplyNumbers(5, 6);
            sw.Stop();
            logger.Info("And the awesome result is: "+addResult.ToString());
            logger.Debug("Which took me " + sw.ElapsedMilliseconds.ToString() + " milliseconds");
        }

    }
}
