using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldd.ViewModel
{
    class MainPageViewModel 
    {
        public string Prompt { set; get; }
        public string Name { set; get; }
        public MainPageViewModel()
        {
            Prompt = "Full Name:";
            Name = "Anima P A";
        }
    }
}
