using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppPrzelicznik
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

        private void ObliczUp(object sender, RoutedEventArgs e)
        {
            double dlugosc = 0;
            miletext.Text = "";
            kmtext.Text = "";
            if (Dlugosc.Text != "")
            {
                dlugosc = double.Parse(Dlugosc.Text);
            }
            else
            {
                MessageBox.Show("Wpisz wartość w polu długość");
            }

            if (mil.IsChecked == true)
            {
                miletext.Text = (dlugosc * 0.00062137).ToString();
            }
            else if (km.IsChecked == true)
            {
                kmtext.Text = (dlugosc * 0.001).ToString();
            }
            else
            {
                MessageBox.Show("Nie wybrałeś jednostki");
            }
        }




        private void ObliczDown(object sender, RoutedEventArgs e)
        {
            double szybkosc = 0;
            if (Szybkosc.Text != "")
            {
                szybkosc = double.Parse(Szybkosc.Text);
            }
            else
            {
                MessageBox.Show("Wpisz wartość w polu szybkość");
            }

            milhtext.Text = "";
            kmhtext.Text = "";
            if (milh.IsChecked == true)
            {
                milhtext.Text = (szybkosc * 2.23693629).ToString();
            }
            else if (kmh.IsChecked == true)
            {
                kmhtext.Text = (szybkosc * 3.6).ToString();
            }
            else
            {
                MessageBox.Show("Nie wybrałeś jednostki");
            }
        }
    }
}