using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Model
{
    public class ProcessModel
    {
        public int ProcessId { get; set; }
        public string? ProcessName { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartTime { get; set; }
    }
}
