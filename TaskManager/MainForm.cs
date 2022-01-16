using System;
using System.Windows.Forms;
using TaskManager.Interfaces;
using TaskManager.Model;
using static TaskManager.Program;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        private readonly IAddProcessService _addProcessByDefault;
        private readonly IAddProcessService _addProcessByFifo;
        private readonly IAddProcessService _addProcessByPriority;
        private readonly IProcessManager _processManager;
        
        public MainForm(ServiceResolver serviceAccessor, IProcessManager processManager)
        {
            _addProcessByDefault = serviceAccessor(AddProcessWays.Default);
            _addProcessByFifo = serviceAccessor(AddProcessWays.FIFO);
            _addProcessByPriority = serviceAccessor(AddProcessWays.Priority);
            _processManager = processManager;

            InitializeComponent();


            ddl_Priority.Text = Priority.Medium.ToString();
            ddl_PriorityForKill.Text = Priority.Medium.ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void btn_AddNewProcess_Click(object sender, EventArgs e)
        {
            _addProcessByDefault.AddProcess(txt_ProcessPath.Text, ResourceHelper.GetPriority(ddl_Priority.SelectedItem.ToString()));
            GetAllProcesses();
        }

        private void btn_AddNewProcessByFifo_Click(object sender, EventArgs e)
        {
            _addProcessByFifo.AddProcess(txt_ProcessPath.Text, ResourceHelper.GetPriority(ddl_Priority.SelectedItem.ToString()));
            GetAllProcesses();
        }

        private void btn_AddProcessByPriority_Click(object sender, EventArgs e)
        {
            _addProcessByPriority.AddProcess(txt_ProcessPath.Text, ResourceHelper.GetPriority(ddl_Priority.SelectedItem.ToString()));
            GetAllProcesses();
        }

        private void btn_KillByPriority_Click(object sender, EventArgs e)
        {
            _processManager.killByPriority(ResourceHelper.GetPriority(ddl_PriorityForKill.SelectedItem.ToString()));
            GetAllProcesses();
        }

        private void btn_KillById_Click(object sender, EventArgs e)
        {
            _processManager.KillById(int.Parse(txt_PId.Text));
            GetAllProcesses();
        }

        private void btn_KillAllProcess_Click(object sender, EventArgs e)
        {
            _processManager.KillAll();
            GetAllProcesses();
        }

        private void btn_GetAllProcesses_Click(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        void GetAllProcesses()
        {
            try
            {
                lv_ProcessList.Items.Clear();
                var processList = ResourceHelper.ProcessList;
                foreach (var item in processList)
                {
                    string[] processDetail = new string[] { item.ProcessName, item.ProcessId.ToString(), item.Priority.ToString(), item.StartTime.ToLongTimeString() };
                    ListViewItem proc = new ListViewItem(processDetail);
                    lv_ProcessList.Items.Add(proc);
                }
                lbl_totalTasks.Text = processList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
            
        }
    }
}
