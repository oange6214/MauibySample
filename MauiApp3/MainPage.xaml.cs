using MauiApp3.Views;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SLayoutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackDemo());
        }

        private void HSLayoutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HStackDemo());
        }
    }
}