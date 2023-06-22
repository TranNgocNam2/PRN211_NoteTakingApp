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
        List<global::Repository.Models.Task> taskList;
        TaskRepository taskRepository;
        private global::Repository.Models.Task todo;
        public Todo()
        {
            InitializeComponent();
            taskRepository = new TaskRepository();
            taskList = taskRepository.GetAll();

            dgvTasks.AutoGenerateColumns = false;
            string[] columnNames = { "Title", "Description", "DueDate", "Done" };

            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = columnName;
                column.HeaderText = columnName;
                dgvTasks.Columns.Add(column);
            }

            dgvTasks.DataSource = taskList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtDescription.Text = "";

            try
            {
                todo.Title = txtTitle.Text;
                todo.Description = txtDescription.Text;
                todo.DueDate = dateTimePicker.Value;

                taskRepository.Create(todo);
                dgvTasks.DataSource = taskRepository.GetAll();
                MessageBox.Show("added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Don't try anything stupid");
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                todo.Title = txtTitle.Text;
                todo.Description = txtDescription.Text;
                todo.DueDate = dateTimePicker.Value;

                MessageBox.Show("Updated!");
                taskRepository.Update(todo);
                dgvTasks.DataSource = taskRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Don't try anything stupid");
            }

        }

        private void dgvTasks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            todo = (taskRepository.GetAll())[e.RowIndex];

            if (todo != null)
            {
                txtTitle.Text = todo.Title;
                txtDescription.Text = todo.Description;
                dateTimePicker.Value = todo.DueDate.Value;
            }
        }
    }
}
