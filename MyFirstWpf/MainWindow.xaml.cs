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

namespace MyFirstWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LinearGradientBrush bg = new LinearGradientBrush(Colors.White, Colors.Green, 90);
        }

        private void SummonStranger_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Bow Down To Us {strangerName.Text}");
        }
    }
}
