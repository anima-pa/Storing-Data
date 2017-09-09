
using helloWorldd.View;
using helloWorldd.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace helloWorldd
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = new MainPageViewModel();
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBinding());
        }

       
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("Alert!", "Do you really want to exit?", "Yes", "No");
                if (true)
                
                await this.Navigation.PopAsync(); // or anything else
            });

            return true;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Behaviours());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Messages());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new DataInMemory());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StoreInSqlite());
        }
    }
}
