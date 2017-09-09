using System;
using Xamarin.Forms;
using helloWorldd.Datas;
using System.IO;
using helloWorldd.iOS;

[assembly: Dependency(typeof(FileHelper))]
namespace helloWorldd.iOS
{
    class FileHelper:IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}