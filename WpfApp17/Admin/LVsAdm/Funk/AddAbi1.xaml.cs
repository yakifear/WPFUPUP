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

namespace WpfApp17.Admin.LVsAdm.Funk
{
    public partial class AddAbi1 : Page
    {
        Abiturienti AbiAbi;
        public AddAbi1(Abiturienti abiturientis)
        {
            this.AbiAbi = abiturientis;
            DataContext = abiturientis;
            InitializeComponent();
        }

        private void BTAddAbi (object sender, RoutedEventArgs e)
        {
            if (AbiAbi.IdAbiturienti == 0)
            {
                ISPr2243_ZobninDS_UPContext.Init().Abiturientis.Add(AbiAbi);
            }
            ISPr2243_ZobninDS_UPContext.Init().SaveChanges();
            NavigationService.Navigate(new AbiturientsAdm());
        }
    }
}
