using App.Core.Iserveices;
using App.Core.Services;
using Autofac;
using Domain.interes.Interfaces;
using Infraestructure.interes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresPratica
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterType<RepositoryInteres>().As<IInteres>();
            builder.RegisterType<InteresServices>().As<IINteresServices>();
            var container = builder.Build();
            Application.Run(new Menu(container.Resolve<IINteresServices>()));
            ////new FmrInteres(container.Resolve<IINteresServices>();
        }
    }
}
