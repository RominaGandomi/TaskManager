using TaskManager.Model;

namespace TaskManager.Interfaces
{
    public interface IAddProcessService
    {
        public void AddProcess(string path, Priority priority);
    }
}
