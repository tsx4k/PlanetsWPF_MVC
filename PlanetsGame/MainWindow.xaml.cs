using PlanetsGame.Properties;
using PlanetsGame.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PlanetsGame
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MVC mvc;

        public MainWindow()
        {
            InitializeComponent();

            this.MouseDown += MainWindow_MouseDown;
            mvc = new MVC();
            mvc.InitializeMVC(this);

            StartTimer();
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mvc.ResetScreensaverTime();
        }

        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            if(mvc.LastViewLoadTime != DateTime.MinValue && DateTime.Now.Subtract(mvc.LastViewLoadTime).TotalMilliseconds > Settings.Default.ScreensaverDelay)
            {
            //    mvc.LoadIntro();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

    }
}
