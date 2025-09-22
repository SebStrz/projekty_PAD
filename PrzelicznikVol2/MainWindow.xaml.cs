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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string inputUID;
        public string outputUID;

        public MainWindow()
        {
            InitializeComponent();
            inputUID = "0";
            outputUID = "2";
        }

        private void MainFunc(object sender, EventArgs e)
        {
            inputUID = InputCombo != null ? (InputCombo.SelectedItem as ComboBoxItem).Uid : "0";
            outputUID = OutputCombo != null ? (OutputCombo.SelectedItem as ComboBoxItem).Uid : "2";
            double inputInMeters;

            

            switch (inputUID)
            {
                case "0":
                    inputInMeters = string.IsNullOrEmpty(InputText.Text) ? 0 : double.Parse(InputText.Text);
                    break;
                case "1":
                    inputInMeters = string.IsNullOrEmpty(InputText.Text) ? 0 : double.Parse(InputText.Text) * 1000;
                    break;
                case "2":
                    inputInMeters = string.IsNullOrEmpty(InputText.Text) ? 0 : double.Parse(InputText.Text) * 1609.344;
                    break;
                default:
                    inputInMeters = 0;
                    break;
            }

            if (OutputText != null)
            {

                switch (outputUID)
                {
                    case "0":
                        OutputText.Text = inputInMeters.ToString();
                        break;
                    case "1":
                        OutputText.Text = (inputInMeters / 1000).ToString();
                        break;
                    case "2":
                        OutputText.Text = (inputInMeters / 1609.344).ToString();
                        break;
                    default:
                        OutputText.Text = "0";
                        break;
                }
            }

            //OutputText.Text = 
        }

        
    }
}