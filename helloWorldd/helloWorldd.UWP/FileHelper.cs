using helloWorldd.Datas;
using helloWorldd.UWP;
using System.IO;
using Windows.Storage;
using System.Collections.Generic;
using Xamarin.Forms;
using System;

[assembly: Dependency(typeof(FileHelper))]
namespace helloWorldd.UWP
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path= Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
            return path;
        }
    }
}
