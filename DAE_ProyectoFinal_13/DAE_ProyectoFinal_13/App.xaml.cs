using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DAE_ProyectoFinal_13.Views.Usuario;
using DAE_ProyectoFinal_13.ViewModels.Base;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DAE_ProyectoFinal_13
{
    public partial class App : Application
    {
        private static ViewModelDependencyInjection _ViewModelDependencyInjection;
        public static ViewModelDependencyInjection ViewModelDependencyInjection
        {
            get { return _ViewModelDependencyInjection = _ViewModelDependencyInjection ?? new ViewModelDependencyInjection(); }
        }


        public App()
        {
            InitializeComponent();
            //MainPage = new ViUsuario();
            MainPage = new Page1();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
