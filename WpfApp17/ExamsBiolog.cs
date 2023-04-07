using System;
using System.Collections.Generic;

namespace WpfApp17
{
    public partial class ExamsBiolog
    {
        public ExamsBiolog()
        {
            Exams = new HashSet<Exam>();
        }

        public int IdExamsBiolog { get; set; }
        public string Predmet { get; set; } = null!;

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
