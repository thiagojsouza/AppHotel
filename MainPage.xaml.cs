using System;
using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelDiarias.Text = $"{(int)e.NewValue} diária(s)";
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}
