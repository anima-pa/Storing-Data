using helloWorldd.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldd.Datas
{
    public class PersonDataBase
    {
        readonly SQLiteAsyncConnection database;
        public PersonDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
    
            database.CreateTableAsync<Persons>().Wait();
        }
        public Task<List<Persons>> GetPeopleAsync()
        {
            return database.Table<Persons>().ToListAsync();
        }
        public Task<Persons> GetPersonAsync(int id)
        {
            return database.Table<Persons>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> SavePersonAsync(Persons person)
        {
            if (person.ID == 0)
            {
                return database.InsertAsync(person);
              //  return database.UpdateAsync(person);
            }
            else
            {
                return database.UpdateAsync(person);
            }
        }
        public Task<int> DeletePersonAsync(Persons person)
        {
            return database.DeleteAsync(person);
        }
        }
}
