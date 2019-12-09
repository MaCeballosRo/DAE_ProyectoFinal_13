using System;
using Xamarin.Forms;
using DAE_ProyectoFinal_13.Interfaces.SQLite;
using DAE_ProyectoFinal_13.Droid.SQLite;
using System.IO;
using System.Buffers;

[assembly: Dependency(typeof(DataBasePathSQLiteAndroid))]
namespace DAE_ProyectoFinal_13.Droid.SQLite
{
    public class DataBasePathSQLiteAndroid : IDataBasePathSQLite
    {
        public string GetDataBasePath()
        {
            var ExternalPath = Android.OS.Environment.ExternalStorageDirectory +
                 Java.IO.File.Separator + "DATATEC" + Java.IO.File.Separator + "DataBase";
            if (!Directory.Exists(ExternalPath))
            {
                Directory.CreateDirectory(ExternalPath);
            }
            ExternalPath = ExternalPath + Java.IO.File.Separator + AppSettings.DataBaseName;
            return ExternalPath;
        }
    }
}