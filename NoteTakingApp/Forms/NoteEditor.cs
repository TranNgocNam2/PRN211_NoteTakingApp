using NoteTakingApp.Authentication.Login;
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
    public partial class NoteEditor : Form
    {
        NoteRepository noteRepository;

        public NoteEditor()
        {
            InitializeComponent();
            noteRepository = new NoteRepository();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            String noteTitle = txtTitle.Text;
            String noteContent = txtContent.Text;
            Note note = new Note()
            {
                UserId = LoginForm.publicUserId,
                Title = noteTitle,
                Content = noteContent,
                CreatedAt = DateTime.Now
            };
            noteRepository.Create(note);
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
