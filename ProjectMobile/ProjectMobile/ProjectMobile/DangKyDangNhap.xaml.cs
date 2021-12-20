using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DangKyDangNhap : ContentPage
    {
        public DangKyDangNhap()
        {
            InitializeComponent();
        }

        private void ExchangeSignUp_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).TextColor = Color.Black;
            BoxViewOfSignUp.Color = Color.Black;

            ExchangeLogin.TextColor = Color.Gray;
            BoxViewOfLogIn.Color = Color.Gray;

            SignUp.IsVisible = true;
            LogIn.IsVisible = false;
        }

        private void ExchangeLogin_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).TextColor = Color.Black;
            BoxViewOfLogIn.Color = Color.Black;

            ExchangeSignUp.TextColor = Color.Gray;
            BoxViewOfSignUp.Color = Color.Gray;

            SignUp.IsVisible = false;
            LogIn.IsVisible = true;
        }
    }
}