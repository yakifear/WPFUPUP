using System;
using System.Collections.Generic;

namespace WpfApp17
{
    public partial class ExamsIt
    {
        public ExamsIt()
        {
            Exams = new HashSet<Exam>();
        }

        public int IdExamsIt { get; set; }
        public string Predmet { get; set; } = null!;

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
