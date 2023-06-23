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
                MessageBox.Show("Must provide a note title !");
                return;
            }
            if (noteList.Any(note => note.Title == updateTitle))
            {
                MessageBox.Show("This note title has already existed !");
                return;
            }
            note.Title = updateTitle;
            note.Content = updateContent;
            noteRepository.Update(note);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
