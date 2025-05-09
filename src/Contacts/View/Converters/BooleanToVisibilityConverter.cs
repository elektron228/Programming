using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    /// <summary>
    /// Выполняет преобразование значений.
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Преобразует значение из <see cref="bool"/> в <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Преобразовываемое значение.</param>
        /// <param name="targetType">Тип, в который преобразовываем.</param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Hidden;
            }
            return Visibility.Hidden;
        }

        /// <summary>
        /// Преобразует значение из <see cref="Visibility"/> в <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Преобразовываемое значение.</param>
        /// <param name="targetType">Тип, в который преобразовываем.</param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value is Visibility visibility && visibility == Visibility.Visible;
        }
    }
}
