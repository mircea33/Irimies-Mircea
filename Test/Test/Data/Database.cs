using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using SQLite;
using Test.Models;

namespace Test.Data
{
    public class Database
    {
        static SQLiteAsyncConnection Databasee;
       public Database()
        {
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
               "Data_base.db");
            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            Stream embeddedDatabaseStream = assembly.GetManifestResourceStream("Test.Data_base.db");
            //if (!File.Exists(DatabasePath))
            //{
            //FileStream fileStreamToWrite = File.Create(DatabasePath);
            //embeddedDatabaseStream.Seek(0, SeekOrigin.Begin);
            //embeddedDatabaseStream.CopyTo(fileStreamToWrite);
            //  fileStreamToWrite.Close();
            //}
            Databasee = new SQLiteAsyncConnection(DatabasePath);
            Databasee.CreateTableAsync<Philosophy>().Wait();
        }
    }
}
