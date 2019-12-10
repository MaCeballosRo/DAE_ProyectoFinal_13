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
            if (!(Entry_IdUsuario.Text == "") && !(Entry_NombreApp.Text == ""))
            {
                int IdUsuario = Convert.ToInt32(Entry_IdUsuario.Text);
                (BindingContext as VmDatosUsuariosVista).LoMetGetDatosUsuarios(IdUsuario);
                (BindingContext as VmDatosUsuariosVista).LoMetGetDatosAplicacion(Entry_NombreApp.Text);
            }          

        }


    }
}