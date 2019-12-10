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
using System.Diagnostics;
using Xamarin.Forms;

namespace DAE_ProyectoFinal_13.ViewModels.Usuarios
{
    public class VmDatosUsuariosVista : INotifyPropertyChanged
    {
        private InterfaceDatosUsuario IFSrvDatosUsuariosLista;

        private ObservableCollection<cat_datosUsuario> OcSfDataGrid_ItemSource_Usuarios;
        public ObservableCollection<cat_datosUsuario> SfDataGrid_ItemSource_Usuarios
        {
            get { return OcSfDataGrid_ItemSource_Usuarios; }
            //set
            //{
            //    if (value != null) FicOcSfDataGrid_ItemSource_Acumulado = value;
            //    RaisePropertyChanged("FicLabel_Binding_Bitacora");
            //}
        }
        private string usuario;
        public string Usuario
        {
            get { return usuario; }

        }

        private string nombreUsuario;
        public string NombreUsuario
        {
            get { return nombreUsuario; }

        }

        private string telefonoUsuario;
        public string TelefonoUsuario
        {
            get { return telefonoUsuario; }

        }

        private string correoUsuario;
        public string CorreoUsuario
        {
            get { return correoUsuario; }

        }

        private string fechaNacUsuario;
        public string FechaNacUsuario
        {
            get { return fechaNacUsuario; }

        }

        private string desarrollador;
        public string Desarrollador
        {
            get { return desarrollador; }

        }

        private string nombreDesarrollador;
        public string NombreDesarrollador
        {
            get { return nombreDesarrollador; }

        }

        private string telefonoDesarrollador;
        public string TelefonoDesarrollador
        {
            get { return telefonoDesarrollador; }

        }

        private string correoDesarrollador;
        public string CorreoDesarrollador
        {
            get { return correoDesarrollador; }

        }

        private string fechaNacDesarrollador;
        public string FechaNacDesarrollador
        {
            get { return fechaNacDesarrollador; }

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

        public async void LoMetGetDatosUsuarios(int PaIdUsuarios)
        {
            try
            {
                var ListaUsuarios = await IFSrvDatosUsuariosLista
                    .IMetGetDatosUsuarioWebApi(PaIdUsuarios);

                //Actualizar el binding de la fuente que llena el grid
                //OcSfDataGrid_ItemSource_Usuarios = new ObservableCollection<cat_datosUsuario>();
                //se realiza ciclo for para llenar la fuente del grid

                foreach (cat_datosUsuario acu in ListaUsuarios)
                {
                    usuario = acu.Usuario;
                    nombreUsuario = acu.Nombre;
                    fechaNacUsuario = acu.FechaNac.ToString();
                    correoUsuario = acu.DireccionWeb;
                    telefonoUsuario = acu.Telefono;
                    //OcSfDataGrid_ItemSource_Usuarios.Add(acu);
                }
                //Se refresca la fuente del grid en la vista

                //RaisePropertyChanged("SfDataGrid_ItemSource_Usuarios");//nombre que le demos al grid en el frontend
                RaisePropertyChanged("Usuario");
                RaisePropertyChanged("NombreUsuario");
                RaisePropertyChanged("FechaNacUsuario");
                RaisePropertyChanged("CorreoUsuario");
                RaisePropertyChanged("TelefonoUsuario");

            }
            catch (Exception e)
            {
                await App.Current.MainPage.DisplayAlert("Alerta", e.Message.ToString(), "Ok");
            }
        }

        public async void LoMetGetDatosDesarrollador(int PaIdDesarrollador)
        {
            try
            {
                var ListaUsuarios = await IFSrvDatosUsuariosLista
                    .IMetGetDatosUsuarioWebApi(PaIdDesarrollador);

                //Actualizar el binding de la fuente que llena el grid
                OcSfDataGrid_ItemSource_Usuarios = new ObservableCollection<cat_datosUsuario>();
                //se realiza ciclo for para llenar la fuente del grid

                foreach (cat_datosUsuario acu in ListaUsuarios)
                {
                    desarrollador = acu.Usuario;
                    nombreDesarrollador = acu.Nombre;
                    fechaNacDesarrollador = acu.FechaNac.ToString();
                    correoDesarrollador = acu.DireccionWeb;
                    telefonoDesarrollador = acu.Telefono;
                    //OcSfDataGrid_ItemSource_Usuarios.Add(acu);
                }
                //Se refresca la fuente del grid en la vista

                //RaisePropertyChanged("SfDataGrid_ItemSource_Usuarios");//nombre que le demos al grid en el frontend
                RaisePropertyChanged("Desarrollador");
                RaisePropertyChanged("NombreDesarrollador");
                RaisePropertyChanged("FechaNacDesarrollador");
                RaisePropertyChanged("CorreoDesarrollador");
                RaisePropertyChanged("TelefonoDesarrollador");

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
