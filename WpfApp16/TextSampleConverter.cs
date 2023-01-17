using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp16
{
    public class MtoKMConverter:
        IValueConverter
    {
        // из кода в интерфейс
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double.TryParse(value.ToString(), out double m);
            return m / 1000.0d + " км";
        }

        // из интерфейса в код
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class MtoSMConverter :
        IValueConverter
    {
        // из кода в интерфейс
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double.TryParse(value.ToString(), out double m);
            return m * 100 + " см";
        }

        // из интерфейса в код
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
