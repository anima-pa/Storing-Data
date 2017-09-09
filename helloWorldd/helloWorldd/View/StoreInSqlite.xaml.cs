using helloWorldd.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace helloWorldd.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StoreInSqlite : ContentPage
	{
        StoreInSqliteViewModel vm;
		public StoreInSqlite ()
		{
			InitializeComponent ();
            vm = new StoreInSqliteViewModel();
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Alert", "Button Clicked...!!!", "OK");
            vm.AddToPeople();
            Navigation.PushAsync(new MainPage());
        }
    }
}