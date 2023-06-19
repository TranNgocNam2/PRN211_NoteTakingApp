using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Note
    {
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
    }
}
