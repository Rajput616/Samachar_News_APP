using Login_Kit.Models;
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
    public partial class NewsContentPage : ContentPage
    {
        public NewsContentPage(News news)
        {
            if (news == null)
            {
                throw new ArgumentNullException();
            }

            BindingContext = news;
            InitializeComponent();
        }
    }
}