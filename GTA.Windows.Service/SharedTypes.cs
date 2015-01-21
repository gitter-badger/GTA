using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Windows.Service
{
    public enum ScheduleTypes
    {
        Monthly,
        Weekly,
        Daily,
        Hourly,
        Interval
    }

    public class Schedule
    {
        public string Naame { get; set; }
        public string Action { get; set; }
        public int Interval { get; set; }
        public ScheduleTypes ScheduleType { get; set; }
    }

    public class Schedules
    {
        public List<Schedule> schedules { get; set; }
    }
}
