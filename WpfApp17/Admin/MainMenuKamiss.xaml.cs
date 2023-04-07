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
using WpfApp17.Admin.LVsAdm;

namespace WpfApp17.Admin
{
    /// <summary>
    /// Interaction logic for MainMenuKamiss.xaml
    /// </summary>
    public partial class MainMenuKamiss : Window
    {
        public MainMenuKamiss()
        {
            InitializeComponent();
        }

        private void BTAbiAdmClick(object sender, RoutedEventArgs e)
        {
            FrameSotr.Navigate(new AbiturientsAdm());
        }   
    }
}
