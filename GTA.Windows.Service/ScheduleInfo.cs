using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Windows.Service
{
    public class ScheduleInfo
    {
        public ScheduleInfo()
        {

        }
        public string Name { get; set; }
        public string Method { get; set; }
        public int Interval { get; set; }
    }
}
