using System.Windows.Input;

namespace MauiApp6.MVVM.ViewModels;

public class CommandViewModel
{
    public ICommand BtnClickCommand => 
        new Command(() => App.Current.MainPage.DisplayAlert("First Command", "You clicked the button", "OK"));
}
