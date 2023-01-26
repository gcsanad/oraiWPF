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

namespace WpfApp1
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

        private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            lbPiros.Content = "Piros:" + Convert.ToInt32(sliPiros.Value);
        }

        private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            lbZold.Content = "Zöld:" + Convert.ToInt32(sliZold.Value);
        }

        private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            lbKek.Content = "Kék:" + Convert.ToInt32(sliKek.Value);
        }
    }
}
