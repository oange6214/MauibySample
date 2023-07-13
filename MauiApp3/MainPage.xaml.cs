﻿using MauiApp3.Views;

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

        private void GridBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridDemo());
        }

        private void OnCalc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalcDemo());
        }

        private void FlexBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexDemo());
        }

        private void AbsoluteBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteDemo());
        }
        
    }
}