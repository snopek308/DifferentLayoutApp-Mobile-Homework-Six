using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DifferentLayoutApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ShowGridPage(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Grid());

        }

        private async void ShowPageThree(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageThree());
        }

        private async void ShowHelloMattPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HelloMattPage());
        }


    }
}
