using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Todo_List.Model;

namespace Todo_List
{
    public partial class Form1 : Form
    {
        private TDListDBContext tdListContext; 
        public Form1()
        {
            InitializeComponent();

            tdListContext = new TDListDBContext();

            var statuses = tdListContext.Statuses.ToList();

            foreach (Status s in statuses)
            {
                cboStatus.Items.Add(s);
            }
            
            chkNotification.Checked = Properties.Settings.Default.NotifyDialog;

            if (chkNotification.Checked)
            {
                refreshData("Start");
            }

            refreshData("All");
        }

        private void refreshData(string typeOfRefresh)
        {
            BindingSource bi = new BindingSource();

            switch (typeOfRefresh)
            {
                case "All":
                    var query = from t in tdListContext.Tasks
                                orderby t.DueDate
                                select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

                    bi.DataSource = query.ToList();
                    break;


                case "ForTheDay":
                    query = from t in tdListContext.Tasks
                                where t.DueDate.Value.Equals(dateTimePicker1.SelectionStart)
                                select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };
                    bi.DataSource = query.ToList();
                    break;

                case "Upcoming":
                    query = from t in tdListContext.Tasks
                                where t.DueDate.Value >= dateTimePicker1.TodayDate
                                select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

                    bi.DataSource = query.ToList();
                    break;

                case "Start":

                    query = from t in tdListContext.Tasks
                            where t.DueDate.Value >= dateTimePicker1.TodayDate
                            select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

                    bi.DataSource = query.ToList();
                    MessageBox.Show("You have " + bi.Count.ToString() + " upcoming tasks.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
            }

            tdListContext.SaveChanges();
            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();


        }

        private void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null && txtTask.Text != String.Empty)
            {
                var newTask = new Model.Task
                {
                    Name = txtTask.Text,
                    StatusId = (cboStatus.SelectedItem as Model.Status).Id,
                    DueDate = dateTimePicker1.SelectionStart.Date
                };

                tdListContext.Tasks.Add(newTask);

                tdListContext.SaveChanges();
                refreshData("All");
            }
            else
            {
                MessageBox.Show("Please enter the required data.", "Create task", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if(cmdUpdateTask.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.SelectionStart = (DateTime)dataGridView1.SelectedCells[3].Value;
                foreach (Status s in cboStatus.Items)
                {
                    if(s.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        cboStatus.Text = s.Name;
                    }
                }
                cmdUpdateTask.Text = "Save";
            }
            else if(cmdUpdateTask.Text == "Save")
            {
                var t = tdListContext.Tasks.Find(dataGridView1.SelectedCells[0].Value);

                t.Name = txtTask.Text;
                t.StatusId = (cboStatus.SelectedItem as Status).Id;
                t.DueDate = dateTimePicker1.SelectionStart.Date;

                tdListContext.SaveChanges();

                refreshData("All");

                cmdUpdateTask.Text = "Update";
                txtTask.Text = string.Empty;
                dateTimePicker1.SelectionStart = DateTime.Now;
                cboStatus.Text = "Please select...";

            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            cmdUpdateTask.Text = "Update";
            txtTask.Text = string.Empty;
            dateTimePicker1.SelectionStart = DateTime.Now;
            cboStatus.Text = "Please select...";
        }


        private void cmdDeleteTask_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want to delete this record?", "Delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var t = tdListContext.Tasks.Find(dataGridView1.SelectedCells[0].Value);

                tdListContext.Tasks.Remove(t);
                tdListContext.SaveChanges();

                refreshData("All");
            }
            
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            refreshData("All");
        }

        private void cmdForTheDay_Click(object sender, EventArgs e)
        {
            refreshData("ForTheDay");
        }

        private void cmdUpcoming_Click(object sender, EventArgs e)
        {
            refreshData("Upcoming");
        }

        private void chkNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotification.Checked)
            {
                Properties.Settings.Default.NotifyDialog = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.NotifyDialog = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
