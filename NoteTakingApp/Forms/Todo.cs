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
using NoteTakingApp.Authentication.Login;

namespace NoteTakingApp.Forms
{
    public partial class Todo : Form
    {
        List<global::Repository.Models.Task> taskList;
        TaskRepository taskRepository;
        private global::Repository.Models.Task todo;
        private int UserId;
        public Todo()
        {
            InitializeComponent();
            taskRepository = new TaskRepository();
            taskList = taskRepository.GetAll();

            dgvTasks.AutoGenerateColumns = false;
            string[] columnNames = { "Title", "Description", "DueDate", "Completed" };

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


            try
            {
                global::Repository.Models.Task todo2 = new global::Repository.Models.Task();
                todo2.UserId = LoginForm.publicUserId;
                todo2.Title = txtTitle.Text;
                todo2.Description = txtDescription.Text;
                todo2.DueDate = dateTimePicker.Value;
                todo2.Completed = false;

                taskRepository.Create(todo2);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (todo != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this todo?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    taskRepository.Delete(todo);
                    dgvTasks.DataSource = taskRepository.GetAll();
                }
            }
        }
    }
}
