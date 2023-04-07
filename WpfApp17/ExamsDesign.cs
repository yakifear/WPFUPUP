using System;
using System.Collections.Generic;

namespace WpfApp17
{
    public partial class ExamsDesign
    {
        public ExamsDesign()
        {
            Exams = new HashSet<Exam>();
        }

        public int IdExamsDesign { get; set; }
        public string Predmet { get; set; } = null!;

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
