using System.Reflection;
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

namespace Weddeberekening
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
        private void salarySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = 0;
            Slider slider = (Slider)sender;

            if (slider != null)
            {
                value = Math.Round(slider.Value, 2);
            }
            PriceCalculater(value);
           
        }

        private void PriceCalculater(double price)
        {
            double newPrice;
            if (price >= 50000)
            {
                newPrice = price / 100 * 90;
            }
            else if (price >= 10000 && price < 50000)
            {
                newPrice = price / 100 * 20;
            }
            else
            {
                newPrice = price;
            }
            labelSalary.Content = $"€{newPrice:N2}";
        }
    }
}