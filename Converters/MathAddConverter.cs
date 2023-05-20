using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace ValueConvertersSample.Converters;

public class MathAddConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (decimal?)value + (decimal?)parameter;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (decimal?)value - (decimal?)parameter;
    }
}
