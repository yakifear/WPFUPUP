using System;
using System.Collections.Generic;

namespace WpfApp17
{
    public partial class Sotrudniki
    {
        public Sotrudniki()
        {

        }

        public int IdSotrudniki { get; set; }
        public string Familia { get; set; } = null!;
        public string Imya { get; set; } = null!;
        public string Otchestvo { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;

    }
}
