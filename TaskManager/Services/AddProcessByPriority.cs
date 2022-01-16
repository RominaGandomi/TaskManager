using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Interfaces;
using TaskManager.Model;

namespace TaskManager.Services
{
    public class AddProcessByPriority :BaseAddProcess, IAddProcessService
    {
        private readonly IProcessManager _processManager;
        public AddProcessByPriority(IProcessManager processManager)
        {
            _processManager = processManager;
        }

        public override void AddProcess(string path, Priority priority)
        {
           
        Start:
            if (!_processManager.CapacityIsFull())
            {
                base.AddProcess(path, priority);
            }
            else
            {
                var lessPriorityProcess = _processManager.GetAll().OrderBy(x => x.Priority).ThenBy(x => x.StartTime).Take(1);
                foreach (var item in lessPriorityProcess)
                {
                    if(item.Priority<priority)
                    {
                        _processManager.KillById(item.ProcessId);
                    }
                    goto Start;
                }
            }
        }
    }
}
