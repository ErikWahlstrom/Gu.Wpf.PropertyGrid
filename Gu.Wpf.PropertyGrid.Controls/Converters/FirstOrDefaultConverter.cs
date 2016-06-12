namespace Gu.Wpf.PropertyGrid
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;
    using System.Windows.Markup;

    [MarkupExtensionReturnType(typeof(IValueConverter))]
    public class FirstOrDefaultConverter : MarkupExtension, IValueConverter
    {
        public static readonly FirstOrDefaultConverter Default = new FirstOrDefaultConverter();

        public FirstOrDefaultConverter()
        {
        }

        /// <inheritdoc/>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as IEnumerable<object>)?.FirstOrDefault();
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException($"{nameof(FirstOrDefaultConverter)} only supports one-way conversion.");
        }
    }
}