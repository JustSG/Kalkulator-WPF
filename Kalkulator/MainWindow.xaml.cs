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

namespace Kalkulator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //String liczba1 = liczba1TextBox.Text;
            //int liczba1int = int.Parse(liczba1TextBox.Text);

            int liczba1;
            int liczba2;
            int wynik = 0;
            if(int.TryParse(liczba1TextBox.Text, out liczba1))
            {
                if (int.TryParse(liczba2TextBox.Text, out liczba2))
                {
                    wynik = liczba1 + liczba2;
                }
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            MessageBox.Show("Wynik dodawania: " + wynik, "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int liczba1;
            int liczba2;
            int wynik = 0;
            if (int.TryParse(liczba1TextBox.Text, out liczba1))
            {
                if (int.TryParse(liczba2TextBox.Text, out liczba2))
                {
                    wynik = liczba1 - liczba2;
                }
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            MessageBox.Show("Wynik odejmowania: " + wynik, "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
