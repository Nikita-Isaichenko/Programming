using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace View.Services
{
    class VisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility returnValue;

            switch ((bool)value)
            {
                case true:
                {
                    returnValue = Visibility.Hidden;
                    break;
                }
                case false:
                {
                    returnValue = Visibility.Visible;
                    break;
                }
            }

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnValue = false;

            switch ((Visibility)value)
            {
                case Visibility.Visible:
                {
                    returnValue = false;
                    break; 
                }
                case Visibility.Collapsed:
                {
                    returnValue = true;
                    break;
                }
                case Visibility.Hidden:
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }
    }
}
