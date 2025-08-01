using Avalonia.Controls;

namespace LOG.ViewModels;

public class DiaryViewModel: ViewModelBase
{
    public string Greeting { get; } = "已进入日志!";
    
    private Button _selectedOption;
    public Button SelectedOption
    {
        get=>_selectedOption;
        set=>SetProperty(ref _selectedOption, value);
    }
    public Button[] Options { get; } =
    {
        new Button(){Content = "[添加日志]"},
        new Button(){Content = "[1.]"},
        new Button(){Content = "[2.]"},
        new Button(){Content = "[3.]"}
        ,
    };
}