using System.Collections.Generic;
using TaskManager.Model;

namespace TaskManager.Interfaces
{
    public interface IProcessManager
    {
        public List<ProcessModel> GetAll();
        public void KillAll();
        public void KillById(int PID);
        public void killByPriority(Priority priority);

        public bool CapacityIsFull();
    }
}
