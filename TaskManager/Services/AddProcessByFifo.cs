using System.Linq;
using TaskManager.Interfaces;
using TaskManager.Model;

namespace TaskManager.Services
{
    public class AddProcessByFifo : BaseAddProcess, IAddProcessService
    {
        private readonly IProcessManager _processManager;
        public AddProcessByFifo(IProcessManager processManager)
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
                var oldestProcessWithLowestPriority = _processManager.GetAll().OrderBy(x => x.StartTime).Take(1);
                foreach (var item in oldestProcessWithLowestPriority)
                {
                    _processManager.KillById(item.ProcessId);
                    goto Start;
                }
            }
        }
    }
}
