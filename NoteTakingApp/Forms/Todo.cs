using Repository.Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace NoteTakingApp.Forms
{
    public partial class Todo : Form
    {
        List<Tasks> taskList;
        TaskRepository taskRepository;
        public Todo()
        {
            InitializeComponent();
            taskRepository = new TaskRepository();
            taskList = taskRepository.GetAll();

            dgvTasks.AutoGenerateColumns = false;
            string[] columnNames = {"Title", "Description", "DueDate", "Done" };

            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = columnName;
                column.HeaderText = columnName;
                dgvTasks.Columns.Add(column);
            }

            dgvTasks.DataSource = taskList;
        }
    }
}
