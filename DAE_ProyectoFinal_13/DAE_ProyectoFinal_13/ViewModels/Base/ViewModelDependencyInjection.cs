using Autofac;
using DAE_ProyectoFinal_13.Interfaces.Usuarios;
using DAE_ProyectoFinal_13.Services;
using DAE_ProyectoFinal_13.ViewModels.Usuarios;

namespace DAE_ProyectoFinal_13.ViewModels.Base
{
    public class ViewModelDependencyInjection
    {
        private static IContainer IContainer;
        
        public ViewModelDependencyInjection()
        {
            var ContainerBuilder = new ContainerBuilder();

            //--------------- View Models ------------------
            ContainerBuilder.RegisterType<VmDatosUsuariosVista>();

            //-------------- Interface Services ------------
            ContainerBuilder.RegisterType<SrvDatosUsuarios>().As<InterfaceDatosUsuario>().SingleInstance();

            if (IContainer != null)
            {
                IContainer.Dispose();
            }
            IContainer = ContainerBuilder.Build();
        }
        //----------------------- Control ------------------
        public VmDatosUsuariosVista VmDatosUsuariosVista { get { return IContainer.Resolve<VmDatosUsuariosVista>(); } }
    }
}
