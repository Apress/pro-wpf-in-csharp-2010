using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;

namespace NotifyIconTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : System.Windows.Application
    {
        private NotifyIconWrapper component;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            component = new NotifyIconWrapper();            
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            component.Dispose();
        }
    }
}