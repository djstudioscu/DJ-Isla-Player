using System;
using System.Windows;
using System.Windows.Threading;

namespace VideoPlayerApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Mostrar la pantalla de inicio (splash) antes de la ventana principal
            var splash = new SplashScreen();
            splash.Show();

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2.8) };
            timer.Tick += (s, args) =>
            {
                timer.Stop();

                var main = new MainWindow();
                main.Show();

                // Cerrar la splash una vez abierta la ventana principal
                splash.Close();
            };
            timer.Start();
        }
    }
}
