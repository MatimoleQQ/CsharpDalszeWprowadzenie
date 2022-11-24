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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Obliczenia_Window.xaml
    /// </summary>
    public partial class Obliczenia_Window : Window
    {
        public Obliczenia_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int bok) && bok>0)
            {
                bool v = int.TryParse(textBox2.Text, out int b);
                if (v)
                {
                    int suma = a + b;

                    MessageBox.Show(suma.ToString(), "Wynik", MessageBoxButton.OK, MessageBoxImage.None);


                }
                else
                {
                    MessageBox.Show("Musi byc  poprawnie wypelniony formularz", "!Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }
            else
            {
                MessageBox.Show("Musi byc  poprawnie wypelniony formularz", "!Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
