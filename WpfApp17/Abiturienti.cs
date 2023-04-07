using System;
using System.Collections.Generic;

namespace WpfApp17
{
    public partial class Abiturienti
    {
        public Abiturienti()
        {

        }

        public int IdAbiturienti { get; set; }
        public string Familia { get; set; } = null!;
        public string Imya { get; set; } = null!;
        public string Otchestvo { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Spec { get; set; } = null!;
        public DateOnly DateR { get; set; }
        public decimal? BalRus { get; set; }
        public decimal? BalMath { get; set; }
        public decimal? BalBiolog { get; set; }
        public decimal? BalInform { get; set; }
        public string? Zachislen { get; set; }
        public int? ExamsIdExams { get; set; }

        public virtual Exam? ExamsIdExamsNavigation { get; set; }
    }
}
