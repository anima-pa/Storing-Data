using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace helloWorldd.ViewModel
{
    class MessagesViewModel
    {
        public ICommand ButtonClickCommand { get; set; }
        public MessagesViewModel()
        {
            ButtonClickCommand = new Command(HandleButtonClick);
        }

        private void HandleButtonClick()
        {
            MessagingCenter.Send<MessagesViewModel>(this, "ButtonClicked");
        }
    }
}
