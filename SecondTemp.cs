using System;

using Xamarin.Forms;

namespace Week4
{
    public class SecondTemp : ContentPage
    {
        public SecondTemp()
        {
            /*
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
            */
            var hostLayout = new StackLayout() { Orientation = StackOrientation.Vertical };
            var celsuisLayout = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var FahrenheitLayout = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var labelCelsuis = new Label() { WidthRequest = 100, Text = "Celsuis" };
            var txtCelsuis = new Entry() { WidthRequest = 100, Placeholder = "Enter celsius temperature value" };

            txtCelsuis.TextChanged += TxtCelsuis_TextChanged;

            void TxtCelsuis_TextChanged(object sender, TextChangedEventArgs e)
            {
                var labelFahrenheit = new Label() { WidthRequest = 100, Text = "Fahrenhit" };
                var txtFahrenheit = new Entry() { WidthRequest = 100 };

                celsuisLayout.Children.Add(labelCelsuis);
                celsuisLayout.Children.Add(txtCelsuis);
                FahrenheitLayout.Children.Add(labelFahrenheit);
                FahrenheitLayout.Children.Add(txtFahrenheit);
                hostLayout.Children.Add(celsuisLayout);
                hostLayout.Children.Add(FahrenheitLayout);

                Content = hostLayout;
                hostLayout.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            }
        }
    }
}

