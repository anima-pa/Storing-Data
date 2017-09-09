using SQLite;
using System.ComponentModel;



namespace helloWorldd.Model
{
   public class Persons
    {
        [PrimaryKey,AutoIncrement]
        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }
         public string ImageSrc { set; get; }
         public decimal Age { set; get; }
        public Persons()
        {

        }
    }
}
