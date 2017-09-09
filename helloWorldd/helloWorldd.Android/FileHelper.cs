using System;
using Xamarin.Forms;
using System.IO;
using helloWorldd.Droid;
using SQLite;
using helloWorldd.Datas;

[assembly: Dependency(typeof(FileHelper))]
namespace helloWorldd.Droid
{
    public class FileHelper:IFileHelper
    {
      /* public SQLiteConnection GetConnection()
        {
            var filename = "SQLiteEx.db3";
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(docFolder, filename);
            return new SQLiteConnection(path);
        }
        
    */
        public string GetLocalFilePath(string filename)
        {
            
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(docFolder, filename);
           
            return path;
        }
    }
}