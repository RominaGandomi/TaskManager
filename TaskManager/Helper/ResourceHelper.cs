using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Text;
using TaskManager.Model;

namespace TaskManager
{
    public static class ResourceHelper
    {
        public static int _capacity;

        public static List<ProcessModel> ProcessList = new List<ProcessModel>();

        public static Priority GetPriority(string strPriority)
        {
            Enum.TryParse(strPriority, out Priority priority);

            return priority;
        }

        public static int Capacity()
        {
            return int.Parse(ConfigurationManager.AppSettings["capacity"]);
        }
    }
}
