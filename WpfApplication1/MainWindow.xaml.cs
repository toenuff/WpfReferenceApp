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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new
            {
                calc = new CalculatorViewModel()
            };
        }
        Page1 p1 = new Page1();
        Page2 p2 = new Page2();
        bool onp1 = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (onp1)
            {
                this.onp1 = false;
                this.NavFrame.Navigate(p1);
            }
            else
            {
                this.onp1 = true;
                this.NavFrame.Navigate(p2);
            }
        }
    }
}
