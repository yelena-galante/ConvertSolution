using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NorthWindConnections.Classes;
using Task = NorthWindConnections.Classes.Task;

namespace NorthWindConnections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Operations.Completed += OperationsOnCompleted;
        }

        private void OperationsOnCompleted(Task sender)
        {
            TaskListView.Items.Add(new ListViewItem(sender.ItemArray));
            TaskListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            TaskListView.FocusedItem = TaskListView.Items[0];
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            Operations.RunTask();
        }
    }

}
