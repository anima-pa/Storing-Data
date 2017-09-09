using helloWorldd.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace helloWorldd.ViewModel
{
    class ListViewPageViewModel
    {
        public ObservableCollection<Persons> People { get; set; } = new ObservableCollection<Persons>();
        public ListViewPageViewModel()
        {
            Persons person = new Persons();
            person.FirstName = "Anima";
            person.LastName = "P A  " ;
            person.PhoneNumber = "9048237522";
            People.Add(person);
            PopulatePeople();
            }
        private async void PopulatePeople()
        {
            List<Persons> people =await App.Database.GetPeopleAsync();
            foreach (Persons p in people)
            {
                People.Add(p);
            }
        }
        }
    }

