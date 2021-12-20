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
    public partial class TimKiem : ContentPage
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void btn_sneakers_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).TextColor = Color.Black;
            boxview_sneakers.IsVisible = true;
            Sneakers.IsVisible = true;

            btn_trousers.TextColor = Color.Gray;
            boxview_trousers.IsVisible = false;
            Trousers.IsVisible = false;

            btn_shirts.TextColor = Color.Gray;
            boxview_shirts.IsVisible = false;
            Shirts.IsVisible = false;
        }

        private void btn_shirts_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).TextColor = Color.Black;
            boxview_shirts.IsVisible = true;
            Shirts.IsVisible = true;

            btn_sneakers.TextColor = Color.Gray;
            boxview_sneakers.IsVisible = false;
            Sneakers.IsVisible = false;

            btn_trousers.TextColor = Color.Gray;
            boxview_trousers.IsVisible = false;
            Trousers.IsVisible = false;
        }

        private void btn_trousers_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).TextColor = Color.Black;
            boxview_trousers.IsVisible = true;
            Trousers.IsVisible = true;

            btn_sneakers.TextColor = Color.Gray;
            boxview_sneakers.IsVisible = false;
            Sneakers.IsVisible = false;

            btn_shirts.TextColor = Color.Gray;
            boxview_shirts.IsVisible = false;
            Shirts.IsVisible = false;
        }
    }
}