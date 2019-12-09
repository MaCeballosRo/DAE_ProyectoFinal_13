using System;
using Xamarin.Forms;
using DAE_ProyectoFinal_13.Interfaces.SQLite;
using DAE_ProyectoFinal_13.iOS.SQLite;
using System.IO;

[assembly: Dependency(typeof(DataBasePathSQLiteiOS))]
namespace DAE_ProyectoFinal_13.iOS.SQLite
{
    public class DataBasePathSQLiteiOS: IDataBasePathSQLite
    {
        public string GetDataBasePath()
        {
            string libFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, AppSettings.DataBaseName);
        }
    }
}