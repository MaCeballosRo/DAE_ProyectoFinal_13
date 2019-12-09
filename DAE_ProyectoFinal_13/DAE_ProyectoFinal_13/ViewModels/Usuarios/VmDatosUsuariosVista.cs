using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using DAE_ProyectoFinal_13.Interfaces.Usuarios;
using DAE_ProyectoFinal_13.Models;

namespace DAE_ProyectoFinal_13.ViewModels.Usuarios
{
    public class VmDatosUsuariosVista : INotifyPropertyChanged
    {
        private InterfaceDatosUsuario IFSrvDatosUsuariosLista;

        private ObservableCollection<cat_usuarios> OcSfDataGrid_ItemSource_Usuarios;
        public ObservableCollection<cat_usuarios> SfDataGrid_ItemSource_Usuarios
        {
            get { return OcSfDataGrid_ItemSource_Usuarios; }
            //set
            //{
            //    if (value != null) FicOcSfDataGrid_ItemSource_Acumulado = value;
            //    RaisePropertyChanged("FicLabel_Binding_Bitacora");
            //}
        }

        public VmDatosUsuariosVista(InterfaceDatosUsuario PaIFSrvDatosUsuariosLista)
        {
            IFSrvDatosUsuariosLista = PaIFSrvDatosUsuariosLista;
        }

        public void OnAppearing()
        {
            //aqui se ejecutan los servicios que vayan a llenara algun componente
            //de la vista al abrirse o regresarse.
        }

        public async void LoMetGetListaUsuarios(int PaIdUsuarios)
        {
            try
            {
                var ListaUsuarios = await IFSrvDatosUsuariosLista
                    .IMetGetDatosUsuarioWebApi(PaIdUsuarios);

                var NombreUsuario = await IFSrvDatosUsuariosLista.IMetGetNombreUsuario(PaIdUsuarios);

                //Actualizar el binding de la fuente que llena el grid
                OcSfDataGrid_ItemSource_Usuarios = new ObservableCollection<cat_usuarios>();
                //se realiza ciclo for para llenar la fuente del grid
                foreach (cat_usuarios acu in ListaUsuarios)
                {
                    OcSfDataGrid_ItemSource_Usuarios.Add(acu);
                }
                //Se refresca la fuente del grid en la vista
                RaisePropertyChanged("SfDataGrid_ItemSource_Usuarios");//nombre que le demos al grid en el frontend

            }
            catch (Exception e)
            {
                await App.Current.MainPage.DisplayAlert("Alerta", e.Message.ToString(), "Ok");
            }
        }
        #region  INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
