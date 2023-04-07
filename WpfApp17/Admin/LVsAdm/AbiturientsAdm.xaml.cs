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
using WpfApp17.Admin.LVsAdm.Funk;

namespace WpfApp17.Admin.LVsAdm
{
    public partial class AbiturientsAdm : Page
    {
        public AbiturientsAdm()
        {
            InitializeComponent();
            Update();
            Soft();
        }
        private void Update()
        {
            LVAbiAdm.ItemsSource = ISPr2243_ZobninDS_UPContext.Init().Abiturientis.ToList();
        }

        private void BTAddAbi(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAbi1(new Abiturienti()));
            Update();
        }

        private void BTEditAbi(object sender, RoutedEventArgs e)
        {
            Abiturienti AbiAbi = LVAbiAdm.SelectedItem as Abiturienti;
                NavigationService.Navigate(new AddAbi1(AbiAbi));
        }

        private void Soft()
        {
            IEnumerable<Abiturienti> spec = ISPr2243_ZobninDS_UPContext.Init().Abiturientis.Where(p => p.Imya.Contains(TBSearch.Text) || p.Familia.Contains(TBSearch.Text) || p.Otchestvo.Contains(TBSearch.Text));
            LVAbiAdm.ItemsSource = spec.ToList();
        }

        private void TBTextChanged(object sender, TextChangedEventArgs e)
        {
            Soft();
        }

        private void BtAbiCard(object sender, RoutedEventArgs e)
        {
            Abiturienti AbiAbi = (sender as Button).DataContext as Abiturienti;
            NavigationService.Navigate(new AddAbi1(AbiAbi));
            Update();
        }

        private void BTDelAbi(object sender, RoutedEventArgs e)
        {
            Abiturienti DelService = LVAbiAdm.SelectedItem as Abiturienti;
            if (MessageBox.Show("Вы дейсвительно хотите удалить запись", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ISPr2243_ZobninDS_UPContext.Init().Remove<Abiturienti>(DelService);

                ISPr2243_ZobninDS_UPContext.Init().SaveChanges();
            }
            Update();
        }
    }
}
