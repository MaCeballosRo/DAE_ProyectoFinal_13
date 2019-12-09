using System.Collections.Generic;
using DAE_ProyectoFinal_13.Models;
using System.Threading.Tasks;

namespace DAE_ProyectoFinal_13.Interfaces.Usuarios
{
     public interface InterfaceDatosUsuario
    {
        Task<List<cat_usuarios>> IMetGetDatosUsuarioWebApi(int IdUsuario);
        //Task<zt_inventarios_acumulados> IMetGetAcumuladosItemWebApi(int PaIdInventario, int PaIdSKU);
        Task<string>IMetGetNombreUsuario(int IdUsuario);
    }
}
