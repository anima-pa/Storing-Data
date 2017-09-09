using helloWorldd.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldd.ViewModel
{
    class StoreInSqliteViewModel
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PhoneNumber { set; get; }
        
        public void AddToPeople()
        {
            Persons person = new Persons();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.PhoneNumber = PhoneNumber;
            App.Database.SavePersonAsync(person);
            
        }
    } }
