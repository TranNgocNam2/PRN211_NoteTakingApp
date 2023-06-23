using NoteTakingApp.Authentication.Login;
using Repository.Models;
using Repository.Repository;

namespace NoteTakingApp.Forms
{
    public partial class NoteEditor : Form
    {
        NoteRepository noteRepository;
        List<Note> noteList;

        public NoteEditor()
        {
            InitializeComponent();
            noteRepository = new NoteRepository();
            noteList = noteRepository.GetAll();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            String noteTitle = txtTitle.Text;
            if (string.IsNullOrEmpty(noteTitle))
            {
                MessageBox.Show("Must provide a note title !");
                return;
            }
            if (noteList.Any(note => note.Title == noteTitle && note.UserId == LoginForm.publicUserId))
            {
                MessageBox.Show("This note title has already existed !");
                return;
            }
            String noteContent = txtContent.Text;
            Note note = new Note()
            {
                UserId = LoginForm.publicUserId,
                Title = noteTitle,
                Content = noteContent,
                CreatedAt = DateTime.Now
            };
            noteRepository.Create(note);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
