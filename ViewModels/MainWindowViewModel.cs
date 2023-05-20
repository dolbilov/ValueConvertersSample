using ReactiveUI;

namespace ValueConvertersSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    #region Fields

    private decimal? _number1 = 2;

    #endregion


    #region Properties

    public decimal? Number1
    {
        get => _number1;
        set => this.RaiseAndSetIfChanged(ref _number1, value);
    }

    #endregion
}