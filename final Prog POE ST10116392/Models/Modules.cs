using System;
using System.Collections.Generic;
namespace final_Prog_POE_ST10116392.Models
{
    public partial class Modules
    {
        public int ModuleId { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public int? Credits { get; set; }
        public int? Hours1 { get; set; }
        public int? Weeks { get; set; }
        public DateTime? Date1 { get; set; }
        public int? SemesterId { get; set; }

        public virtual Semester Semester { get; set; }
    }
}
