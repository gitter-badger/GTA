using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Windows.Service
{
    public class Schedule
    {
        public string action { get; set; }
        public int interval { get; set; }
    }

    public class Schedules
    {
        public List<Schedule> schedules { get; set; }
    }
}
