using Prism.Unity;
using Serilog;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using MailList.Module;
using MailContext.Module;
using PrismExampleWpf.Model;
using Infrastructure;

namespace PrismExampleWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell(Window shell)
        {
            LoggerRunner.Run();

            Log.Information("Hi from eviXscan Measurement Analizer");
            Log.Debug("Initializing shell");

            base.InitializeShell(shell);
            shell.Show();

            Log.Debug("Initialized shell");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Container.Resolve<IApplicationViewManager>().ShowView("MailContextV");

        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationViewManager, ApplicationViewManager>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        { 
            base.ConfigureModuleCatalog(moduleCatalog);
            _ = moduleCatalog.AddModule<MailListModule>()
                .AddModule<MailContextModule>();
        }
    }
}
