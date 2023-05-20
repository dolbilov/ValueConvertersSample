using System;
using ReactiveUI;
using ValueConvertersSample.Models;

namespace ValueConvertersSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    #region Fields

    private decimal? _number1 = 2;
    private decimal? _number2 = 3;
    private Operations _operation;

    #endregion


    #region Properties

    public decimal? Number1
    {
        get => _number1;
        set => this.RaiseAndSetIfChanged(ref _number1, value);
    }

    public decimal? Number2
    {
        get => _number2;
        set => this.RaiseAndSetIfChanged(ref _number2, value);
    }

    public Operations Operation
    {
        get => _operation;
        set => this.RaiseAndSetIfChanged(ref _operation, value);
    }

    public Array AvailableOperations { get; } = Enum.GetValues(typeof(Operations));

    #endregion
}
