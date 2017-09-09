using helloWorldd.Model;
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
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            BindingContext = new ListViewPageViewModel();
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem==null)
            { return;
            }
            Persons person = e.SelectedItem as Persons;
            DisplayAlert("Selected", person.FirstName + person.LastName, "OK");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StoreInSqlite());
        }
    }
}