using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA.Windows.Service
{
    public class ConfigHandler : IConfigurationSectionHandler
    {

            public ConfigHandler() { }

            public object Create(object parent,
                   object configContext, System.Xml.XmlNode section)
            {
                ScheduleInfo objScheduleInfo = new ScheduleInfo();
                objScheduleInfo.Name = section.SelectSingleNode("Name").InnerText;
                objScheduleInfo.Method = section.SelectSingleNode("Method").InnerText;
                objScheduleInfo.Interval = Convert.ToInt32(section.SelectSingleNode("Interval").InnerText);
                return objScheduleInfo;
            }
        
    }
}
