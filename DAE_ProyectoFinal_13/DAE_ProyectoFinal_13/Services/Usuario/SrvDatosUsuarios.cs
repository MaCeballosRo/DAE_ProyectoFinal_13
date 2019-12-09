using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DAE_ProyectoFinal_13.Interfaces.SQLite;
using DAE_ProyectoFinal_13.Data;
using DAE_ProyectoFinal_13.Interfaces.Usuarios;
using DAE_ProyectoFinal_13.Models;

namespace DAE_ProyectoFinal_13.Services
{
    public class SrvDatosUsuarios : InterfaceDatosUsuario
    {
        private DataBaseContext LocalDBContext;
        private readonly HttpClient HttpClient;

        public SrvDatosUsuarios()
        {
            LocalDBContext = new DataBaseContext(DependencyService.Get<IDataBasePathSQLite>().GetDataBasePath());
            HttpClient = new HttpClient();
        }

        public async Task<List<cat_usuarios>> IMetGetDatosUsuarioWebApi(int PaIdUsuario)
        {
            string FicURL = AppSettings.UrlBase.ToString() + "api/usuarios/todosUsuarios?PaIdUsuario=" + PaIdUsuario;//poner la dirección correspondiente de la API
            try
            {

                var Respuesta = await HttpClient.GetAsync(FicURL);
                Console.WriteLine("Respuesta: " + Respuesta);
                return Respuesta.IsSuccessStatusCode ? JsonConvert.DeserializeObject<List<cat_usuarios>>(await Respuesta.Content.ReadAsStringAsync()) : null;
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("ERROR", e.Message.ToString(), "Ok");
                return null;
            }
        }

        public async Task<string> IMetGetNombreUsuario (int PaIdUsuario)
        {
            string FicURL = AppSettings.UrlBase.ToString() + "api/usuarios/nombreUsuarios?PaIdUsuario=" + PaIdUsuario;//poner la dirección correspondiente de la API
            try
            {

                var Respuesta = await HttpClient.GetAsync(FicURL);
                Console.WriteLine("Respuesta: " + Respuesta);
                return Respuesta.IsSuccessStatusCode ? JsonConvert.DeserializeObject<string>(await Respuesta.Content.ReadAsStringAsync()) : null;
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("ERROR", e.Message.ToString(), "Ok");
                return null;
            }
        }
    }
}
