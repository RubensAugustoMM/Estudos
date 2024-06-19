using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaApplication.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    public string Greeting => "Welcome to Avalonia!";
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
    }

    private string _textBlockName = "Welcome to Avalonia!"; //baking field
    public string TextBlockName  //property name
    {
        get => _textBlockName;
        set
        {
            _textBlockName = value;
            OnPropertyChanged();
        }
    }

    public void ButtonOnClick()
    {
        TextBlockName = "oi";
    }
}
