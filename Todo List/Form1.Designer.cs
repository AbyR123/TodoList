
namespace Todo_List
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdUpcoming = new System.Windows.Forms.Button();
            this.cmdAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.MonthCalendar();
            this.cmdForTheDay = new System.Windows.Forms.Button();
            this.showTasks = new System.Windows.Forms.Label();
            this.chkNotification = new System.Windows.Forms.CheckBox();
            this.dueDate = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdUpdateTask = new System.Windows.Forms.Button();
            this.cmdCreateTask = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 205);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdUpcoming);
            this.groupBox1.Controls.Add(this.cmdAll);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmdForTheDay);
            this.groupBox1.Controls.Add(this.showTasks);
            this.groupBox1.Controls.Add(this.chkNotification);
            this.groupBox1.Controls.Add(this.dueDate);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.task);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmdDeleteTask);
            this.groupBox1.Controls.Add(this.cmdUpdateTask);
            this.groupBox1.Controls.Add(this.cmdCreateTask);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // cmdUpcoming
            // 
            this.cmdUpcoming.Location = new System.Drawing.Point(347, 171);
            this.cmdUpcoming.Name = "cmdUpcoming";
            this.cmdUpcoming.Size = new System.Drawing.Size(105, 28);
            this.cmdUpcoming.TabIndex = 21;
            this.cmdUpcoming.Text = "Upcoming";
            this.cmdUpcoming.UseVisualStyleBackColor = true;
            this.cmdUpcoming.Click += new System.EventHandler(this.cmdUpcoming_Click);
            // 
            // cmdAll
            // 
            this.cmdAll.Location = new System.Drawing.Point(110, 171);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(105, 28);
            this.cmdAll.TabIndex = 20;
            this.cmdAll.Text = "All";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(578, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cmdForTheDay
            // 
            this.cmdForTheDay.Location = new System.Drawing.Point(231, 171);
            this.cmdForTheDay.Name = "cmdForTheDay";
            this.cmdForTheDay.Size = new System.Drawing.Size(105, 28);
            this.cmdForTheDay.TabIndex = 18;
            this.cmdForTheDay.Text = "For The Day";
            this.cmdForTheDay.UseVisualStyleBackColor = true;
            this.cmdForTheDay.Click += new System.EventHandler(this.cmdForTheDay_Click);
            // 
            // showTasks
            // 
            this.showTasks.AutoSize = true;
            this.showTasks.Location = new System.Drawing.Point(6, 171);
            this.showTasks.Name = "showTasks";
            this.showTasks.Size = new System.Drawing.Size(88, 17);
            this.showTasks.TabIndex = 17;
            this.showTasks.Text = "Show Tasks:";
            // 
            // chkNotification
            // 
            this.chkNotification.AutoSize = true;
            this.chkNotification.Location = new System.Drawing.Point(578, 241);
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(100, 21);
            this.chkNotification.TabIndex = 11;
            this.chkNotification.Text = "Notification";
            this.chkNotification.UseVisualStyleBackColor = true;
            this.chkNotification.CheckedChanged += new System.EventHandler(this.chkNotification_CheckedChanged);
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Location = new System.Drawing.Point(494, 25);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(72, 17);
            this.dueDate.TabIndex = 10;
            this.dueDate.Text = "Due Date:";
            this.dueDate.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(6, 64);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(52, 17);
            this.status.TabIndex = 9;
            this.status.Text = "Status:";
            // 
            // task
            // 
            this.task.AutoSize = true;
            this.task.Location = new System.Drawing.Point(6, 22);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(43, 17);
            this.task.TabIndex = 7;
            this.task.Text = "Task:";
            this.task.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(261, 106);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 28);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Location = new System.Drawing.Point(377, 106);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(75, 28);
            this.cmdDeleteTask.TabIndex = 5;
            this.cmdDeleteTask.Text = "Delete";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdUpdateTask
            // 
            this.cmdUpdateTask.Location = new System.Drawing.Point(180, 106);
            this.cmdUpdateTask.Name = "cmdUpdateTask";
            this.cmdUpdateTask.Size = new System.Drawing.Size(75, 28);
            this.cmdUpdateTask.TabIndex = 4;
            this.cmdUpdateTask.Text = "Update";
            this.cmdUpdateTask.UseVisualStyleBackColor = true;
            this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
            // 
            // cmdCreateTask
            // 
            this.cmdCreateTask.Location = new System.Drawing.Point(68, 106);
            this.cmdCreateTask.Name = "cmdCreateTask";
            this.cmdCreateTask.Size = new System.Drawing.Size(75, 28);
            this.cmdCreateTask.TabIndex = 3;
            this.cmdCreateTask.Text = "Create";
            this.cmdCreateTask.UseVisualStyleBackColor = true;
            this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(68, 64);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(117, 24);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Text = "Please Select....";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(71, 22);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(381, 22);
            this.txtTask.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox chkNotification;
        private System.Windows.Forms.Label showTasks;
        private System.Windows.Forms.Button cmdForTheDay;
        private System.Windows.Forms.MonthCalendar dateTimePicker1;
        private System.Windows.Forms.Button cmdUpcoming;
        private System.Windows.Forms.Button cmdAll;
    }
}

