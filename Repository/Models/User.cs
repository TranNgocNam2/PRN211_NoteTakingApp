using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class User
    {
        public User()
        {
            Notes = new HashSet<Note>();
            Tasks = new HashSet<Task>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
