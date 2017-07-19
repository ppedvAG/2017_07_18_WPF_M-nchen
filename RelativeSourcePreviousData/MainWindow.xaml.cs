using System.Collections.Generic;
using System.Windows;

namespace RelativeSourcePreviousData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            items.ItemsSource = GetData();
        }

        private IEnumerable<Item> GetData()
        {
            return new List<Item>
            {
                new Item { Value = 90 },
                new Item { Value = 0 },
                new Item { Value = 34},
                new Item { Value = 70 },
                new Item { Value = 58 },
                new Item { Value = 47 },
                new Item { Value = 124 },
                new Item { Value = 56 },
                new Item { Value = 97 },
                new Item { Value = 173 },
                new Item { Value = 20 },
                new Item { Value = 57 },
                new Item { Value = 28 },
                new Item { Value = 79 },
                new Item { Value = 200 },
                new Item { Value = 94 },
                new Item { Value = 83 },
                new Item { Value = 10 }
            };
        }
    }
}
