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
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
            BindingContext = App.ViewModelDependencyInjection.VmDatosUsuariosVista;
            InitializeComponent ();
		}

        void Button_Clicked_Consultar(object sender, EventArgs arg)
        {
            int IdUsuario = Convert.ToInt32(Entry_IdUsuario.Text);
            int IdDesarrollador = Convert.ToInt32(Entry_IdDesarrollador.Text);
            (BindingContext as VmDatosUsuariosVista).LoMetGetDatosUsuarios(IdUsuario);
            (BindingContext as VmDatosUsuariosVista).LoMetGetDatosDesarrollador(IdDesarrollador);

        }


    }
}