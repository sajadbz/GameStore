using GameStore.Winform.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore.Winform
{
    static class Program
    {
        public static ServiceProvider ServiceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddScoped<frmMain>();
            services.AddScoped<frmGameDetail>();
            services.AddScoped<frmCartDetails>();
            services.AddScoped<frmGroups>();
            services.AddScoped<frmGroupDetail>();

            IoC.Container container = new IoC.Container();
            ServiceProvider = container.Register(services);


            var frm = ServiceProvider.GetService<frmMain>();
            Application.Run(frm);

        }
    }
}
