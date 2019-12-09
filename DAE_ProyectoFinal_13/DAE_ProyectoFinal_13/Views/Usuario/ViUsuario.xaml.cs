using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DAE_ProyectoFinal_13.ViewModels.Usuarios;

namespace DAE_ProyectoFinal_13.Views.Usuario
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViUsuario : ContentPage
	{
		public ViUsuario ()
		{
            BindingContext = App.ViewModelDependencyInjection.VmDatosUsuariosVista;
            InitializeComponent();
		}

        protected override void OnAppearing()
        {

        }

        void Button_Clicked_Consultar(object sender, EventArgs arg)
        {
            int IdUsuario = Convert.ToInt32(Entry_IdUsuario.Text);
            (BindingContext as VmDatosUsuariosVista).LoMetGetListaUsuarios(IdUsuario);

            /*int IdDesarrollador = Convert.ToInt32(Entry_IdDesarrollador.Text);
            (BindingContext as VmDatosUsuariosVista).LoMetGetListaUsuarios(IdDesarrollador);*/
        }

        async void Button_Clicked_Cancelar(object sender, EventArgs args)
        {
            bool Confirmar = await App.Current.MainPage.DisplayAlert
                                ("ALERTA", "¿Desea Limpiar la Busqueda?", "Sí", "No");
            if (Confirmar)
            {
                //FicGrid_IsVisible_Running.IsVisible = true;
                //FicActivityIndicator_Importar.IsVisible = true;
                //FicActivityIndicator_Importar.IsRunning = true;

                Entry_IdUsuario.Text = "";

                //FicGrid_IsVisible_Running.IsVisible = false;
                //FicActivityIndicator_Importar.IsVisible = false;
                //FicActivityIndicator_Importar.IsRunning = false;
            }
        }
    }
}