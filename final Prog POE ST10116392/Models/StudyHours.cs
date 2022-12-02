using System;
using System.Collections.Generic;
namespace final_Prog_POE_ST10116392.Models
{
    public partial class StudyHours
    {
        public int? Hours1 { get; set; }
        public DateTime? Date1 { get; set; }
        public int? ModuleId { get; set; }

        public virtual Modules Module { get; set; }
    }
}
