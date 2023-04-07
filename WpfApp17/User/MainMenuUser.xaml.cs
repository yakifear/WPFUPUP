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
using WpfApp17.User.LVs;
using WpfApp17.User.LVs.Design;
using WpfApp17.User.LVs.IT;

namespace WpfApp17.User
{
    /// <summary>
    /// Interaction logic for MainMenuUser.xaml
    /// </summary>
    public partial class MainMenuUser : Window
    {
        public MainMenuUser()
        {
            InitializeComponent();
        }

        private void BtSpec(object sender, RoutedEventArgs e)
        {
            FrameUser.Navigate(new SpecPage());
        }
    }
}
