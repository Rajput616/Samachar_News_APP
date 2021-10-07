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
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();
            if(Application.Current.Properties != null && 
                Application.Current.Properties.ContainsKey("Logged_in") &&
                Application.Current.Properties["Logged_in"].Equals(true))
            {
                Username.Text = (string) Application.Current.Properties["Username"];
                Password.Text = (string) Application.Current.Properties["Password"];
                RememberMeCheckBox.IsToggled = true;
            }
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.Properties != null &&
                    Application.Current.Properties.ContainsKey("Username") &&
                    Application.Current.Properties.ContainsKey("Password"))
            {

                if ( !String.IsNullOrWhiteSpace(Username.Text) && Username.Text.Equals(Application.Current.Properties["Username"])){
                    await DisplayAlert("Congratulations", "Your Password is - " + Application.Current.Properties["Password"], "Login Now");
                }
                else
                {
                    await DisplayAlert("Error", "Username is wrong, Please enter it again or Sign Up", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Important Message", "No records present in the database", "Please Sign Up");
            }
        }

        async private void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }
        async private void SignIn_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Username.Text))
            {
                await DisplayAlert("Error", "Username is Empty!!", "OK");

            }
            else if (String.IsNullOrWhiteSpace(Password.Text))
            {
                await DisplayAlert("Error", "Password is Empty!!", "OK");
            }
            else
            {
                if (Application.Current.Properties != null &&
                    Application.Current.Properties.ContainsKey("Username") &&
                    Application.Current.Properties.ContainsKey("Password"))
                {
                    if (Username.Text.Equals(Application.Current.Properties["Username"])
                        && Password.Text.Equals(Application.Current.Properties["Password"]))
                    {
                        if (RememberMeCheckBox.IsToggled)
                        {
                            Application.Current.Properties["Logged_in"] = true;
                        }
                        else
                        {
                            Application.Current.Properties["Logged_in"] = false;
                        }
                        await Navigation.PushAsync(new HomePage());
                    }
                    else
                    {
                        await DisplayAlert("Error", "Username or Password entered is Wrong!", "Enter Again");
                    }
                }
                else
                {
                    await DisplayAlert("Alert", "No records present, Please Sign Up", "OK");
                }
            }
        }

    }
}