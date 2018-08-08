using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week4
{
    public partial class TempratureConverter : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            txtFah.Text = (int.Parse(txtCelsius.Text) * 1.8 + 32.0).ToString();
            //throw new NotImplementedException();
        }

        public TempratureConverter()
        {
            InitializeComponent();
        }
    }
}
