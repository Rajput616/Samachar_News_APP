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
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            if (Application.Current.Properties == null)
            {
                genderImage.Source = "userMale.png";
                firstName.Text = "System";
                gender_button.Text = "Male";
                fullName.Text = "Fake";
                Email.Text = "fakeemail@gmail.com";
                phoneNo.Text = "XXXXXXXXX";
            }
            else
            {
                if (Application.Current.Properties["Gender"].Equals("Male"))
                {
                    genderImage.Source = "userMale.png";
                }
                else
                {
                    genderImage.Source = "userFemale.png";
                }
                firstName.Text = "Hi " + (string)Application.Current.Properties["first_name"];
                gender_button.Text = (string)Application.Current.Properties["Gender"];
                fullName.Text = (string)Application.Current.Properties["first_name"] + " " + (string)Application.Current.Properties["last_name"];
                Email.Text = (string)Application.Current.Properties["Username"];
                phoneNo.Text = (string)Application.Current.Properties["Phone"];
            }
        }


        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LogoutPage());
        }
    }
}