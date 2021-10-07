using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Kit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash_screen : ContentPage
    {
        public Splash_screen()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            LogoAnimation();
        }
        public async Task LogoAnimation()
        {
            //imgLogo.Opacity = 0;
            //await imgLogo.FadeTo(1, 6000);
            await Task.Delay(4000);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}