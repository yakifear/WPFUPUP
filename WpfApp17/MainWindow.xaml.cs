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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp17.Admin;
using WpfApp17.User;

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdmLog(object sender, RoutedEventArgs e)
        {
            AdmAuthorization wind = new AdmAuthorization();
            wind.Show();
            Hide();
        }

        private void UserLog(object sender, RoutedEventArgs e)
        {
            UserAuthorization wind = new UserAuthorization();
            wind.Show();
            Hide();
        }
    }
}
