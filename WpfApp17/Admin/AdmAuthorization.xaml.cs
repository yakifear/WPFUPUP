using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp17.Admin
{
    /// <summary>
    /// Interaction logic for AdmAuthorization.xaml
    /// </summary>
    public partial class AdmAuthorization : Window
    {
        public AdmAuthorization()
        {
            InitializeComponent();
        }

        private void BtBackAdm(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            Hide();
        }

        private void BrLoginAdm(object sender, RoutedEventArgs e)
        {
            Sotrudniki user = ISPr2243_ZobninDS_UPContext.Init().Sotrudnikis.FirstOrDefault(p => p.Login == TbLoginAdm.Text && p.Password == TbPassAdm.Text);
            if (user != null)
            {
                if (user.Role == "Сотрудник приемной комиссии")
                {
                    MainMenuKamiss wind = new MainMenuKamiss();
                    wind.Show();
                    Hide();
                }
                if (user.Role == "Консультант ")
                {
                    MainMenuKonsultant w = new MainMenuKonsultant();
                    w.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные");
            }

        }
    }
}
