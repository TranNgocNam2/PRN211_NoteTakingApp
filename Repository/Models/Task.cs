using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Completed { get; set; }

        public virtual User User { get; set; }
    }
}
