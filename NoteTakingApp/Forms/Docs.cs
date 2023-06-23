using NoteTakingApp.Authentication.Login;
using Repository.Models;
using Repository.Repository;
using System.Data;

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
            noteList = noteRepository.GetAll().Where(note => note.UserId == LoginForm.publicUserId).ToList();

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
            NoteEditor noteEditorPanel = new NoteEditor();
            noteEditorPanel.ShowDialog();
            noteList = noteRepository.GetAll().Where(note =>
                        note.UserId == LoginForm.publicUserId).ToList();
            dgvListNote.DataSource = noteList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvListNote.CurrentRow;

            if (selectedRow != null)
            {
                string noteTitle = selectedRow.Cells[0].Value.ToString();
                Note note = noteList.FirstOrDefault(entity => entity.Title.Equals(noteTitle));

                DialogResult result = MessageBox.Show("Are you sure you want to delete this note: " + noteTitle
                    + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    bool isDeleted = noteRepository.Delete(note);

                    if (isDeleted)
                    {
                        noteList = noteRepository.GetAll().Where(note =>
                        note.UserId == LoginForm.publicUserId).ToList();
                        dgvListNote.DataSource = noteList;
                        MessageBox.Show("Deleted successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Please select a note tilte to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int lastClickedRowIndex = -1;
        private int lastClickedColumnIndex = -1;

        private void dgvListNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvListNote.Columns[e.ColumnIndex].Index == 0)
            {
                if (e.RowIndex == lastClickedRowIndex && e.ColumnIndex == lastClickedColumnIndex)
                {
                    DataGridViewRow selectedRow = dgvListNote.Rows[e.RowIndex];
                    string noteTitle = selectedRow.Cells[0].Value.ToString();
                    Note note = noteList.FirstOrDefault(entity => entity.Title.Equals(noteTitle));

                    // Open the NoteUpdateEditor form and pass the selected note as a parameter
                    NoteUpdateEditor updateForm = new NoteUpdateEditor(note);
                    updateForm.ShowDialog();

                    // Refresh the DataGridView after the update form is closed
                    noteList = noteRepository.GetAll().Where(n => n.UserId == LoginForm.publicUserId).ToList();
                    dgvListNote.DataSource = noteList;
                }

                // Update the last clicked cell index
                lastClickedRowIndex = e.RowIndex;
                lastClickedColumnIndex = e.ColumnIndex;
            }

        }
    }
}
