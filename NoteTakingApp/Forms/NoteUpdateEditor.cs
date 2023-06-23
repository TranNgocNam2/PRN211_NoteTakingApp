using NoteTakingApp.Authentication.Login;
using Repository.Models;
using Repository.Repository;

namespace NoteTakingApp.Forms
{
    public partial class NoteUpdateEditor : Form
    {
        NoteRepository noteRepository;
        private Note note;
        List<Note> noteList;

        public NoteUpdateEditor(Note note)
        {
            InitializeComponent();
            noteRepository = new NoteRepository();
            noteList = noteRepository.GetAll();
            this.note = note;

            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string updateTitle = txtTitle.Text;
            string updateContent = txtContent.Text;

            if (string.IsNullOrEmpty(updateTitle))
            {
                MessageBox.Show("Must provide a note title!");
                return;
            }

            // Retrieve the existing note from the context
            Note existingNote = noteList.FirstOrDefault(n => n.NoteId == note.NoteId);

            // Check if an existing note with the same title exists
            if (existingNote != null && existingNote.Title != updateTitle)
            {
                bool isTitleAlreadyExists = noteRepository.GetAll()
                     .Any(note => note.Title == updateTitle && note.UserId == LoginForm.publicUserId
                     && note.NoteId != existingNote.NoteId);

                if (isTitleAlreadyExists)
                {
                    MessageBox.Show("This note title has already existed!");
                    return;
                }
            }

  
            existingNote.Title = updateTitle;
            existingNote.Content = updateContent;

            noteRepository.Update(existingNote);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
