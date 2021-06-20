using System;
using System.Globalization;
using Xamarin.Forms;

namespace linkdev_xamarin_task.Converters
{
    public class DoublesizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return (double)value * 2;
            }
            catch(Exception ex)
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            try
            {
                return (double)value / 2;
            }
            catch (Exception ex)
            {
                return value;
            }
        }
    }
}
