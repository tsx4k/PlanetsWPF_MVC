using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PlanetsGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            WebBrowserHostUIHandler.WebBrowserDisableBouncing();
            WebBrowserHostUIHandler.WebBrowserDisableZoom();



            Unosquare.FFME.Library.FFmpegDirectory = @"c:\ffmpeg";
            //            Unosquare.FFME.MediaElement.FFmpegDirectory = @"p:\!tools\ffmpeg\bin";
            // You can pick which FFmpeg binaries are loaded. See issue #28
            // Full Features is already the default.
            //            Unosquare.FFME.Library.FFmpegLoadModeFlags = 
            // Multithreaded video enables the creation of independent
            // dispatcher threads to render video frames.
            Unosquare.FFME.Library.EnableWpfMultiThreadedVideo = false; // GuiContext.Current.IsInDebugMode == false;
            try
            {
                // Force loading
                if (!Unosquare.FFME.Library.LoadFFmpeg()) throw new Exception("");
            }
            catch (Exception ex)
            {
                /*
                MessageBox.Show(
    $"Unable to Load FFmpeg Libraries from path:\r\n    {Unosquare.FFME.Library.FFmpegDirectory}" +
    $"\r\n{ex.GetType().Name}: {ex.Message}\r\n\r\n", // Application will exit.
    "FFmpeg Error",
    MessageBoxButton.OK,
    MessageBoxImage.Error);
                */
            }
        }
    }
}
