using System.Collections.Generic;
using DAE_ProyectoFinal_13.Models;
using System.Threading.Tasks;

namespace DAE_ProyectoFinal_13.Interfaces.Usuarios
{
     public interface InterfaceDatosUsuario
    {
        Task<List<cat_datosUsuario>> IMetGetDatosUsuarioWebApi(int IdUsuario);
        Task<List<cat_datosApp>> IMetGetApp(string NombreApliciacion);
        Task<List<cat_datosUsuario>> IMetGetDatosUsuarioDesarrollador(string usuarioDesarrollador);
        //Task<zt_inventarios_acumulados> IMetGetAcumuladosItemWebApi(int PaIdInventario, int PaIdSKU);
        //Task<string> IMetGetPersonas(int IdUsuario);
    }
}
