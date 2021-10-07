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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        async private void SignIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignIn());
        }
        async private void SignUp_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UsernameSU.Text))
            {
                await DisplayAlert("Error", "Enter Username!!", "OK");

            } else if(String.IsNullOrWhiteSpace(first_nameSU.Text) || String.IsNullOrWhiteSpace(last_nameSU.Text))
            {
                await DisplayAlert("Error", "Enter Name!!", "OK");
            }
            else if(String.IsNullOrWhiteSpace(PasswordSU.Text))
            {
                await DisplayAlert("Error", "Enter Password!!", "OK");
            }
            else if (String.IsNullOrWhiteSpace(PhoneSU.Text))
            {
                await DisplayAlert("Error", "Enter Phone Numeber!!", "OK");
            }
            else if (String.IsNullOrWhiteSpace((string)Gender_pickerSU.SelectedItem))
            {
                await DisplayAlert("Error", "Select Gender!!", "OK");
            }
            else
            {
                if (Application.Current.Properties != null && Application.Current.Properties.ContainsKey("Username") && UsernameSU.Text.Equals(Application.Current.Properties["Username"]))
                {
                    await DisplayAlert("Info", "Username already present, Please Login", "OK");
                }
                else
                {
                    Application.Current.Properties["Username"] = UsernameSU.Text;
                    Application.Current.Properties["first_name"] = first_nameSU.Text;
                    Application.Current.Properties["last_name"] = last_nameSU.Text;
                    Application.Current.Properties["Password"] = PasswordSU.Text;
                    Application.Current.Properties["Phone"] = PhoneSU.Text;
                    Application.Current.Properties["Gender"] = (string)Gender_pickerSU.SelectedItem;
                    await Navigation.PushAsync(new HomePage());
                }
            }
        }
    }
}