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
            var returnValue = Visibility.Hidden;

            switch (value)
            {
                case true:
                {
                    returnValue = Visibility.Visible;
                    break;
                }
                case false:
                {
                    returnValue = Visibility.Hidden;
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
                    returnValue = true;
                    break; 
                }
                case Visibility.Collapsed:
                {
                    returnValue = false;
                    break;
                }
                case Visibility.Hidden:
                {
                    returnValue = false;
                    break;
                }
            }

            return returnValue;
        }
    }
}
