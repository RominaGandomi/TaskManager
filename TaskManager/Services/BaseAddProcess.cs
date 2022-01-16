using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TaskManager.Model;

namespace TaskManager.Services
{
    public abstract class BaseAddProcess
    {

        public virtual void AddProcess(string path, Priority priority)
        {
            try
            {
                Process process = Process.Start(path);
                ResourceHelper.ProcessList.Add(new ProcessModel()
                {
                    Priority = priority,
                    ProcessName = Path.GetFileName(path),
                    ProcessId = process.Id,
                    StartTime = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }

        }
    }
}
