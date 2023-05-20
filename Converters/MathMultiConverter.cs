using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ValueConvertersSample.Models;

namespace ValueConvertersSample.Converters;

public class MathMultiConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values.Count != 3)
        {
            Trace.WriteLine("Exactly 3 values expected");
            return BindingOperations.DoNothing;
        }

        var operation = (Operations)values[0];
        var number1 = values[1] as decimal? ?? 0;
        var number2 = values[2] as decimal? ?? 0;

        switch (operation)
        {
            case Operations.Add:
                return number1 + number2;
            case Operations.Subtract:
                return number1 - number2;
            case Operations.Multiply:
                return number1 * number2;
            case Operations.Divide:
                if (number2 == 0)
                    return new BindingNotification(new DivideByZeroException("Don't do this"), BindingErrorType.Error);
                return number1 / number2;
        }

        return new BindingNotification(new InvalidOperationException("Something went wrong"), BindingErrorType.Error);
    }
}