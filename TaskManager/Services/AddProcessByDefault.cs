using System.Windows.Forms;
using TaskManager.Interfaces;
using TaskManager.Model;

namespace TaskManager.Services
{
    public class AddProcessByDefault : BaseAddProcess, IAddProcessService
    {
        private readonly IProcessManager _processManager;

        public AddProcessByDefault(IProcessManager processManager)
        {
            _processManager = processManager;
        }

        public override void AddProcess(string path, Priority priority)
        {
            if (!_processManager.CapacityIsFull())
            {
                base.AddProcess(path, priority);
            }
            else
                MessageBox.Show("Task count have been reached the maximum capacity!");
        }
    }
}
