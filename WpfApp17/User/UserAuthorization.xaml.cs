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

namespace WpfApp17.User
{
    /// <summary>
    /// Interaction logic for UserAuthorization.xaml
    /// </summary>
    public partial class UserAuthorization : Window
    {
        public UserAuthorization()
        {
            InitializeComponent();
        }

        private void BtBackUser(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            Hide();
        }

        private void BtLoginUser(object sender, RoutedEventArgs e)
        {
            Abiturienti user = ISPr2243_ZobninDS_UPContext.Init().Abiturientis.FirstOrDefault(p => p.Login == TbLoginUser.Text && p.Password == TbPasswordUser.Text);

            if (user != null)
            {
                MainMenuUser wind = new MainMenuUser();
                wind.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные.");
            }
        }
    }
}
