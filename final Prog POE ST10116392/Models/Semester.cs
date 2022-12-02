using System;
using System.Collections.Generic;
namespace final_Prog_POE_ST10116392.Models
{
    public partial class Semester
    {
        public Semester()
        {
            Modules = new HashSet<Modules>();
        }

        public int SemesterId { get; set; }
        public int? Weeks { get; set; }
        public DateTime? Date1 { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Modules> Modules { get; set; }
    }
}
