using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TaskManager.Interfaces;
using TaskManager.Model;

namespace TaskManager.Services
{
    public class ProcessManager : IProcessManager
    {
        public List<ProcessModel> GetAll()
        {
            return ResourceHelper.ProcessList.OrderBy(x => x.StartTime).ToList();
        }

        public void KillAll()
        {
            foreach (var item in ResourceHelper.ProcessList.ToList())
                KillProcess(item);
        }

        public void KillById(int PID)
        {
            var process = ResourceHelper.ProcessList.First(x => x.ProcessId == PID);
            KillProcess(process);
        }

        public void killByPriority(Priority priority)
        {
            var processGroup = GetAll().Where(x => x.Priority == priority).ToList();
            foreach (var item in processGroup)
                KillProcess(item);
        }

        public bool CapacityIsFull()
        {
            var result = GetAll().Count >= ResourceHelper.Capacity();
            return result;
        }

        private void KillProcess(ProcessModel process)
        {
            try
            {
                Process.GetProcessById(process.ProcessId).Kill();
                ResourceHelper.ProcessList.Remove(process);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }

        }
    }
}
