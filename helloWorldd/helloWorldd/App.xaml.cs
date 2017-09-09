﻿using helloWorldd.Datas;
using helloWorldd.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace helloWorldd
{
    public partial class App : Application
    {
        static PersonDataBase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StoreInSqlite());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        public static PersonDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.db3"));
                }
              
                return database;
            }
        }
    }
}
