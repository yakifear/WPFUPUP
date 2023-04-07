using Microsoft.EntityFrameworkCore;
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

namespace WpfApp17.User.LVs
{
    /// <summary>
    /// Interaction logic for LVIT.xaml
    /// </summary>
    public partial class LVIT : Page
    {
        public LVIT()
        {
            InitializeComponent();
            Sort();
            Update();

            CBSortByName.Items.Add("По возрастанию");
            CBSortByName.Items.Add("По убыванию");

            CBBal.IsChecked = true;
            CBEco.IsChecked = true;
        }

        private void Sort()
        {
            //Поиск
            IEnumerable<Abiturienti> spec = ISPr2243_ZobninDS_UPContext.Init().Abiturientis.Where(p => p.Spec.Contains(TBSearch.Text) || p.Imya.Contains(TBSearch.Text) || p.Familia.Contains(TBSearch.Text) || p.Otchestvo.Contains(TBSearch.Text));

            //Возрастание, убывание
            
            switch (CBSortByName.SelectedIndex)
            {
                case 0:
                    spec = spec.OrderBy(p => p.Spec);
                    break;
                case 1:
                    spec = spec.OrderByDescending(p => p.Spec);
                    break;
            }

            if (CBEco.IsChecked.Value)
            {
                spec = spec.Where(p => p.Spec == "Экология").ToList();
            }

            LvIT.ItemsSource = spec.ToList();
        }

        private void Update()
        {
            LvIT.ItemsSource = ISPr2243_ZobninDS_UPContext.Init().Abiturientis.ToList();
        }

        private void TBTextChanged(object sender, TextChangedEventArgs e)
        {
            Sort();
        }

        private void CBSelChanged(object sender, SelectionChangedEventArgs e)
        {
            Sort();
        }

        private void CBSortChanged(object sender, SelectionChangedEventArgs e)
        {
            Sort();
        }

        private void CBUn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LVITBal());
        }

        private void CBEcoChecked(object sender, RoutedEventArgs e)
        {
            Sort();
        }

        private void CBEcoUn(object sender, RoutedEventArgs e)
        {
            Sort();
        }
    }
}
