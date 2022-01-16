
using TaskManager.Interfaces;
using TaskManager.Model;
using static TaskManager.Program;

namespace TaskManager
{
    partial class MainForm
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_AddNewProcess = new System.Windows.Forms.Button();
            this.newProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lv_ProcessList = new System.Windows.Forms.ListView();
            this.processName = new System.Windows.Forms.ColumnHeader();
            this.processId = new System.Windows.Forms.ColumnHeader();
            this.processPriority = new System.Windows.Forms.ColumnHeader();
            this.ProcessStartTime = new System.Windows.Forms.ColumnHeader();
            this.txt_ProcessPath = new System.Windows.Forms.TextBox();
            this.lblProcessPath = new System.Windows.Forms.Label();
            this.btn_KillAllProcess = new System.Windows.Forms.Button();
            this.btn_KillByPriority = new System.Windows.Forms.Button();
            this.btn_AddNewProcessByFifo = new System.Windows.Forms.Button();
            this.btn_AddProcessByPriority = new System.Windows.Forms.Button();
            this.txt_PId = new System.Windows.Forms.TextBox();
            this.btn_KillById = new System.Windows.Forms.Button();
            this.btn_GetAllProcesses = new System.Windows.Forms.Button();
            this.lbl_ProcessPriority = new System.Windows.Forms.Label();
            this.lbl_totalTasks = new System.Windows.Forms.Label();
            this.ddl_Priority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddl_PriorityForKill = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddNewProcess
            // 
            this.btn_AddNewProcess.Location = new System.Drawing.Point(670, 34);
            this.btn_AddNewProcess.Name = "btn_AddNewProcess";
            this.btn_AddNewProcess.Size = new System.Drawing.Size(199, 29);
            this.btn_AddNewProcess.TabIndex = 0;
            this.btn_AddNewProcess.Text = "Add New Process";
            this.btn_AddNewProcess.UseVisualStyleBackColor = true;
            this.btn_AddNewProcess.Click += new System.EventHandler(this.btn_AddNewProcess_Click);
            // 
            // newProcessToolStripMenuItem
            // 
            this.newProcessToolStripMenuItem.Name = "newProcessToolStripMenuItem";
            this.newProcessToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.newProcessToolStripMenuItem.Text = "New Process";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProcessToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 28);
            // 
            // lv_ProcessList
            // 
            this.lv_ProcessList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lv_ProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.processId,
            this.processPriority,
            this.ProcessStartTime});
            this.lv_ProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ProcessList.FullRowSelect = true;
            this.lv_ProcessList.HideSelection = false;
            this.lv_ProcessList.Location = new System.Drawing.Point(3, 134);
            this.lv_ProcessList.Name = "lv_ProcessList";
            this.lv_ProcessList.Size = new System.Drawing.Size(653, 442);
            this.lv_ProcessList.TabIndex = 5;
            this.lv_ProcessList.UseCompatibleStateImageBehavior = false;
            this.lv_ProcessList.View = System.Windows.Forms.View.Details;
            // 
            // processName
            // 
            this.processName.Text = "Process Name";
            this.processName.Width = 300;
            // 
            // processId
            // 
            this.processId.Text = "PID";
            this.processId.Width = 100;
            // 
            // processPriority
            // 
            this.processPriority.Text = "Priority";
            this.processPriority.Width = 100;
            // 
            // ProcessStartTime
            // 
            this.ProcessStartTime.Text = "Start Time";
            this.ProcessStartTime.Width = 150;
            // 
            // txt_ProcessPath
            // 
            this.txt_ProcessPath.Location = new System.Drawing.Point(121, 25);
            this.txt_ProcessPath.Name = "txt_ProcessPath";
            this.txt_ProcessPath.Size = new System.Drawing.Size(535, 27);
            this.txt_ProcessPath.TabIndex = 6;
            // 
            // lblProcessPath
            // 
            this.lblProcessPath.AutoSize = true;
            this.lblProcessPath.Location = new System.Drawing.Point(3, 25);
            this.lblProcessPath.Name = "lblProcessPath";
            this.lblProcessPath.Size = new System.Drawing.Size(93, 20);
            this.lblProcessPath.TabIndex = 7;
            this.lblProcessPath.Text = "Process Path:";
            // 
            // btn_KillAllProcess
            // 
            this.btn_KillAllProcess.Location = new System.Drawing.Point(670, 478);
            this.btn_KillAllProcess.Name = "btn_KillAllProcess";
            this.btn_KillAllProcess.Size = new System.Drawing.Size(199, 29);
            this.btn_KillAllProcess.TabIndex = 8;
            this.btn_KillAllProcess.Text = "Kill All Processes";
            this.btn_KillAllProcess.UseVisualStyleBackColor = true;
            this.btn_KillAllProcess.Click += new System.EventHandler(this.btn_KillAllProcess_Click);
            // 
            // btn_KillByPriority
            // 
            this.btn_KillByPriority.Location = new System.Drawing.Point(670, 288);
            this.btn_KillByPriority.Name = "btn_KillByPriority";
            this.btn_KillByPriority.Size = new System.Drawing.Size(199, 29);
            this.btn_KillByPriority.TabIndex = 9;
            this.btn_KillByPriority.Text = "Kill By Priority";
            this.btn_KillByPriority.UseVisualStyleBackColor = true;
            this.btn_KillByPriority.Click += new System.EventHandler(this.btn_KillByPriority_Click);
            // 
            // btn_AddNewProcessByFifo
            // 
            this.btn_AddNewProcessByFifo.Location = new System.Drawing.Point(670, 69);
            this.btn_AddNewProcessByFifo.Name = "btn_AddNewProcessByFifo";
            this.btn_AddNewProcessByFifo.Size = new System.Drawing.Size(199, 29);
            this.btn_AddNewProcessByFifo.TabIndex = 11;
            this.btn_AddNewProcessByFifo.Text = "Add New Process(FIFO)";
            this.btn_AddNewProcessByFifo.UseVisualStyleBackColor = true;
            this.btn_AddNewProcessByFifo.Click += new System.EventHandler(this.btn_AddNewProcessByFifo_Click);
            // 
            // btn_AddProcessByPriority
            // 
            this.btn_AddProcessByPriority.Location = new System.Drawing.Point(670, 104);
            this.btn_AddProcessByPriority.Name = "btn_AddProcessByPriority";
            this.btn_AddProcessByPriority.Size = new System.Drawing.Size(199, 29);
            this.btn_AddProcessByPriority.TabIndex = 12;
            this.btn_AddProcessByPriority.Text = "Add New Process(Priority)";
            this.btn_AddProcessByPriority.UseVisualStyleBackColor = true;
            this.btn_AddProcessByPriority.Click += new System.EventHandler(this.btn_AddProcessByPriority_Click);
            // 
            // txt_PId
            // 
            this.txt_PId.Location = new System.Drawing.Point(670, 420);
            this.txt_PId.Name = "txt_PId";
            this.txt_PId.Size = new System.Drawing.Size(199, 27);
            this.txt_PId.TabIndex = 14;
            // 
            // btn_KillById
            // 
            this.btn_KillById.Location = new System.Drawing.Point(670, 385);
            this.btn_KillById.Name = "btn_KillById";
            this.btn_KillById.Size = new System.Drawing.Size(199, 29);
            this.btn_KillById.TabIndex = 13;
            this.btn_KillById.Text = "Kill By PID";
            this.btn_KillById.UseVisualStyleBackColor = true;
            this.btn_KillById.Click += new System.EventHandler(this.btn_KillById_Click);
            // 
            // btn_GetAllProcesses
            // 
            this.btn_GetAllProcesses.Location = new System.Drawing.Point(3, 99);
            this.btn_GetAllProcesses.Name = "btn_GetAllProcesses";
            this.btn_GetAllProcesses.Size = new System.Drawing.Size(653, 29);
            this.btn_GetAllProcesses.TabIndex = 15;
            this.btn_GetAllProcesses.Text = "Get All Processes";
            this.btn_GetAllProcesses.UseVisualStyleBackColor = true;
            this.btn_GetAllProcesses.Click += new System.EventHandler(this.btn_GetAllProcesses_Click);
            // 
            // lbl_ProcessPriority
            // 
            this.lbl_ProcessPriority.AutoSize = true;
            this.lbl_ProcessPriority.Location = new System.Drawing.Point(3, 69);
            this.lbl_ProcessPriority.Name = "lbl_ProcessPriority";
            this.lbl_ProcessPriority.Size = new System.Drawing.Size(112, 20);
            this.lbl_ProcessPriority.TabIndex = 16;
            this.lbl_ProcessPriority.Text = "Process Priority:";
            // 
            // lbl_totalTasks
            // 
            this.lbl_totalTasks.AutoSize = true;
            this.lbl_totalTasks.Location = new System.Drawing.Point(786, 551);
            this.lbl_totalTasks.Name = "lbl_totalTasks";
            this.lbl_totalTasks.Size = new System.Drawing.Size(0, 20);
            this.lbl_totalTasks.TabIndex = 18;
            // 
            // ddl_Priority
            // 
            this.ddl_Priority.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddl_Priority.FormattingEnabled = true;
            this.ddl_Priority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.ddl_Priority.Location = new System.Drawing.Point(121, 66);
            this.ddl_Priority.Name = "ddl_Priority";
            this.ddl_Priority.Size = new System.Drawing.Size(151, 28);
            this.ddl_Priority.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Tasks:";
            // 
            // ddl_PriorityForKill
            // 
            this.ddl_PriorityForKill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddl_PriorityForKill.FormattingEnabled = true;
            this.ddl_PriorityForKill.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.ddl_PriorityForKill.Location = new System.Drawing.Point(670, 323);
            this.ddl_PriorityForKill.Name = "ddl_PriorityForKill";
            this.ddl_PriorityForKill.Size = new System.Drawing.Size(199, 28);
            this.ddl_PriorityForKill.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 588);
            this.Controls.Add(this.ddl_PriorityForKill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_Priority);
            this.Controls.Add(this.lbl_totalTasks);
            this.Controls.Add(this.lbl_ProcessPriority);
            this.Controls.Add(this.btn_GetAllProcesses);
            this.Controls.Add(this.txt_PId);
            this.Controls.Add(this.btn_KillById);
            this.Controls.Add(this.btn_AddProcessByPriority);
            this.Controls.Add(this.btn_AddNewProcessByFifo);
            this.Controls.Add(this.btn_KillByPriority);
            this.Controls.Add(this.btn_KillAllProcess);
            this.Controls.Add(this.lblProcessPath);
            this.Controls.Add(this.txt_ProcessPath);
            this.Controls.Add(this.lv_ProcessList);
            this.Controls.Add(this.btn_AddNewProcess);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_AddNewProcess;


        #endregion

        private System.Windows.Forms.ToolStripMenuItem newProcessToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lv_ProcessList;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader processId;
        private System.Windows.Forms.ColumnHeader processPriority;
        private System.Windows.Forms.TextBox txt_ProcessPath;
        private System.Windows.Forms.Label lblProcessPath;
        private System.Windows.Forms.Button btn_KillAllProcess;
        private System.Windows.Forms.Button btn_KillByPriority;
        private System.Windows.Forms.Button btn_AddNewProcessByFifo;
        private System.Windows.Forms.Button btn_AddProcessByPriority;
        private System.Windows.Forms.TextBox txt_PId;
        private System.Windows.Forms.Button btn_KillById;
        private System.Windows.Forms.Button btn_GetAllProcesses;
        private System.Windows.Forms.Label lbl_ProcessPriority;
        private System.Windows.Forms.Label lbl_totalTasks;
        private System.Windows.Forms.ColumnHeader ProcessStartTime;
        private System.Windows.Forms.ComboBox ddl_Priority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddl_PriorityForKill;
    }
}
