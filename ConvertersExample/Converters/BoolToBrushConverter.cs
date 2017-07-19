using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ConvertersExample.Converters
{
    internal class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter != null && parameter is string[] colors)
            {
                return (bool)value ? colors[0] : colors[1];
            }


            return (bool)value ? Brushes.Green : Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
