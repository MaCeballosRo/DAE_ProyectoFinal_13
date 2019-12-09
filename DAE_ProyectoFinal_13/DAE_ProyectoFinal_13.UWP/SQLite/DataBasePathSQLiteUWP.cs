using System;
using Windows.Storage;
using Xamarin.Forms;
using DAE_ProyectoFinal_13.Interfaces.SQLite;
using DAE_ProyectoFinal_13.UWP.SQLite;
using System.IO;

[assembly: Dependency(typeof(DataBasePathSQLiteUWP))]
namespace DAE_ProyectoFinal_13.UWP.SQLite
{
    public class DataBasePathSQLiteUWP: IDataBasePathSQLite
    {
        public string GetDataBasePath()
        {
            //Tarea:Codigo para crear el directorio, como en android

            return Path.Combine(ApplicationData.Current.LocalFolder.Path, AppSettings.DataBaseName);
        }// Este método obtiene la ruta física de la base de datos de este dispositivo
    }
}
