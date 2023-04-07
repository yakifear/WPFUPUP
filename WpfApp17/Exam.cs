using System;
using System.Collections.Generic;

namespace WpfApp17
{
    public partial class Exam
    {
        public Exam()
        {
            Abiturientis = new HashSet<Abiturienti>();
        }

        public int IdExams { get; set; }
        public int ExamsBiologIdExamsBiolog { get; set; }
        public int ExamsDesignIdExamsDesign { get; set; }
        public int ExamsItIdExamsIt { get; set; }

        public virtual ExamsBiolog ExamsBiologIdExamsBiologNavigation { get; set; } = null!;
        public virtual ExamsDesign ExamsDesignIdExamsDesignNavigation { get; set; } = null!;
        public virtual ExamsIt ExamsItIdExamsItNavigation { get; set; } = null!;
        public virtual ICollection<Abiturienti> Abiturientis { get; set; }
    }
}
