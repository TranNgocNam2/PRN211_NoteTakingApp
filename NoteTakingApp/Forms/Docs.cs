
using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp.Forms
{
    public partial class Docs : Form
    {
        List<Note> noteList;
        NoteRepository noteRepository;

        public Docs()
        {
            InitializeComponent();
            noteRepository = new NoteRepository();
            noteList = noteRepository.GetAll();

            dgvListNote.AutoGenerateColumns = false;

            string[] columnNames = { "Title", "Content", "CreatedAt" };

            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = columnName;
                column.HeaderText = columnName;
                dgvListNote.Columns.Add(column);
            }

            dgvListNote.DataSource = noteList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            List<Note> filteredNotesList;
            if (string.IsNullOrEmpty(searchName))
            {
                filteredNotesList = noteList;
            }
            else
            {
                filteredNotesList = noteList
                    .Where(note => note.Title.Contains(searchName))
                    .ToList();
            }

            dgvListNote.DataSource = filteredNotesList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
