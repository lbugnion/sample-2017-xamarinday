using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarinForms
{
    public partial class MainPage : ContentPage
    {
        private int _counter;

        public MainPage()
        {
            InitializeComponent();

            MyButton.Clicked += (s, e) =>
            {
                MyText.Text = $"Counter clicked {++_counter} times";
            };
        }
    }
}
