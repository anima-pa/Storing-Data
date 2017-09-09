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
    public partial class Messages : ContentPage
    {
        public Messages()
        {
            InitializeComponent();
            BindingContext =new MessagesViewModel();
            MessagingCenter.Subscribe<MessagesViewModel>(new MessagesViewModel(), "ButtonClicked", (sender) =>
              {
                  DisplayAlert("Alert", "Button Clicked...!!!", "OK");
              }
            );

        }
    }
}