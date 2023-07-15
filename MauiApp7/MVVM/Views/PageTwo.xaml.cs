using MauiApp7.MVVM.ViewModels;

namespace MauiApp7.MVVM.Views;

public partial class PageTwo : ContentPage
{
	public PageTwo()
	{
		InitializeComponent();
        BindingContext = new PageTwoViewModel();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageOne());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageThree());
    }
}