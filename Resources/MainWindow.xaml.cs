using Resources.Properties;
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

namespace Resources
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

        private void StaticResourceChangeValue_Click(object sender, RoutedEventArgs e)
        {
            var colorBrush = Resources["defaultBackgroundColor"];

            if (colorBrush is SolidColorBrush c)
                c.Color = Colors.Blue;

        }

        private void StaticResourceChangeInstance_Click(object sender, RoutedEventArgs e)
        {
            Resources["defaultBackgroundColor"] = new SolidColorBrush(Colors.Fuchsia);
        }

        private void OpenNewWindow(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void StaticResourceChangeType_Click(object sender, RoutedEventArgs e)
        {
            Resources["defaultBackgroundColor"] = new RadialGradientBrush(Colors.Fuchsia, Colors.Gold);
        }
    }
}
