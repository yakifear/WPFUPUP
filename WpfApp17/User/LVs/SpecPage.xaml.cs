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
using WpfApp17.User.LVs.Design;
using WpfApp17.User.LVs.IT;

namespace WpfApp17.User.LVs
{
    /// <summary>
    /// Interaction logic for SpecPage.xaml
    /// </summary>
    public partial class SpecPage : Page
    {
        public SpecPage()
        {
            InitializeComponent();
        }
        private void BtIT(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LVITBal());
        }

        private void BTEco(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LVITUn());
        }

        private void BtDesign(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LVDesignUn());
        }
    }
}
