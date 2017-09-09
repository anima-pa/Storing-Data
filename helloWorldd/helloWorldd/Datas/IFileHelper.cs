using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace helloWorldd.Datas
{
   public interface IFileHelper
    {
       string GetLocalFilePath(string filename);
       //SQLiteConnection GetConnection();
    }
}
 