using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TaskManager.Interfaces;
using TaskManager.Model;
using TaskManager.Services;

namespace TaskManager
{
    public static class Program
    {
        public delegate IAddProcessService ServiceResolver(AddProcessWays key);

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

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(form1);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IProcessManager, ProcessManager>();
            services.AddTransient<AddProcessByDefault>();
            services.AddTransient<AddProcessByFifo>();
            services.AddTransient<AddProcessByPriority>();

            services.AddTransient<ServiceResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case AddProcessWays.Default:
                        return serviceProvider.GetService<AddProcessByDefault>();
                    case AddProcessWays.FIFO:
                        return serviceProvider.GetService<AddProcessByFifo>();
                    case AddProcessWays.Priority:
                        return serviceProvider.GetService<AddProcessByPriority>();
                    default:
                        return serviceProvider.GetService<AddProcessByDefault>();
                }
            });

            services.AddScoped<MainForm>();
        }
    }
}
