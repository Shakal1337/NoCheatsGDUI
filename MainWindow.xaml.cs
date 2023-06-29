using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
using System.Security.Policy;
using System.Diagnostics;

namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Source src = new Source();
        



        public MainWindow()
        {
         
            bool MainDirectorySearch = File.Exists(@"C:\ProgramData\InS\NoCheatsGD(UI)\result");


            //InitializeComponent();
            if (MainDirectorySearch == true) { }
            else
            {
                Directory.CreateDirectory(@"C:\ProgramData\InS\NoCheatsGD(UI)\result");
            }

            if (Settings.Default.FirstRun == true)
            {
                FirstRun firstRun = new FirstRun();
                firstRun.Show();
                
            }
            else
            {
                InitializeComponent();
            }

            if (Settings.Default.FirstRun == false)
            {
                if (Settings.Default.GdBotIsTouch == false)
                {
                    gdboton.Visibility = Visibility.Hidden;
                    gdbotoff.Visibility = Visibility.Visible;
                }

                else
                {
                    gdboton.Visibility = Visibility.Visible;
                    gdbotoff.Visibility = Visibility.Hidden;
                }

                if (Settings.Default.GDHMIsTouch == false) 
                {
                    gdhmon.Visibility = Visibility.Hidden;
                    gdhmoff.Visibility = Visibility.Visible;
                
                }
                else
                {
                    gdhmon.Visibility = Visibility.Visible;
                    gdhmoff.Visibility = Visibility.Hidden;
                }

            }

           



            if (string.IsNullOrEmpty(Settings.Default.GDHMMoveSettingsByPass)) 
            {
                check.Visibility = Visibility.Hidden;
                uncheked.Visibility = Visibility.Visible;
            }
        }

        private void gdbotoffon(object sender, RoutedEventArgs e)
        {
            File.Move(Settings.Default.GDBotMoveSettings + @"\" + Settings.Default.GDBotName, 
                src.MainFloder + @"\" + Settings.Default.GDBotName ,
                overwrite:false );

            Settings.Default.GdBotIsTouch = true;
            Settings.Default.Save();

            gdboton.Visibility = Visibility.Visible;
            gdbotoff.Visibility = Visibility.Hidden;
        }

        private void gdboton_clck(object sender, RoutedEventArgs e)
        {
            File.Move(src.MainFloder + @"\" + Settings.Default.GDBotName, 
                Settings.Default.GDBotMoveSettings + @"\" + Settings.Default.GDBotName, 
                overwrite:false);

            Settings.Default.GdBotIsTouch = false;
            Settings.Default.Save();

            gdboton.Visibility = Visibility.Hidden;
            gdbotoff.Visibility = Visibility.Visible;

        }

        private void gdhmoff_clck(object sender, RoutedEventArgs e)
        {
            #region move
            File.Move(
                Settings.Default.GDHMMoveSettingsByPass ,
                src.MainFloder + @"\" + src.ModeName[0],
                overwrite:false
                );

            File.Move(
                Settings.Default.GDHMMoveSettingsCore,
                src.MainFloder + @"\" + src.ModeName[1],
                overwrite: false
                );

            File.Move(
                Settings.Default.GDHMMoveSettingsGlobal,
                src.MainFloder + @"\" + src.ModeName[2],
                overwrite: false
                );

            File.Move(
                Settings.Default.GDHMMoveSettingsPlayer,
                src.MainFloder + @"\" + src.ModeName[3],
                overwrite: false
                );

            File.Move(
                Settings.Default.GDHMMoveSettingsvVriables,
                src.MainFloder + @"\" + src.ModeName[4],
                overwrite: false
                );

            File.Move(
                Settings.Default.GDHMMoveSettingsCreator,
                src.MainFloder + @"\" + src.ModeName[5],
                overwrite: false
                );
            #endregion
            Settings.Default.GDHMIsTouch = true;
            Settings.Default.Save();
            gdhmon.Visibility = Visibility.Visible;
            gdhmoff.Visibility = Visibility.Hidden;
            

        }

        private void gdhmon_clck(object sender, RoutedEventArgs e)
        {
            #region move to gd directory
            File.Move(
                src.MainFloder + @"\" + src.ModeName[0],
                Settings.Default.GDHMMoveSettingsByPass,
                overwrite: false
                );

            File.Move(
                src.MainFloder + @"\" + src.ModeName[1],
                Settings.Default.GDHMMoveSettingsCore,
                overwrite: false
                );

            File.Move(
                src.MainFloder + @"\" + src.ModeName[2],
                Settings.Default.GDHMMoveSettingsGlobal,
                overwrite: false
                );

            File.Move(
                src.MainFloder + @"\" + src.ModeName[3],
                Settings.Default.GDHMMoveSettingsPlayer,
                overwrite: false
                );

            File.Move(
                src.MainFloder + @"\" + src.ModeName[4],
                Settings.Default.GDHMMoveSettingsvVriables,
                overwrite: false
                );

            File.Move(
                 src.   MainFloder + @"\" + src.ModeName[5],
                Settings.Default.GDHMMoveSettingsCreator,
                overwrite: false
                );
            #endregion
            Settings.Default.GDHMIsTouch = false;
            Settings.Default.Save();
            gdhmon.Visibility = Visibility.Hidden;
            gdhmoff.Visibility = Visibility.Visible;
        }







        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void crosswhiteEnter(object sender, MouseEventArgs e)
        {
            closewhite.Opacity = 0;
            closered.Opacity = 100;
        }

        private void crossredLeave(object sender, MouseEventArgs e)
        {
            closewhite.Opacity = 100;
            closered.Opacity = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.FirstRun = true;
            Settings.Default.Save();

            MessageBox.Show($"{Settings.Default.GdBotIsTouch} {src.ModeName[0]}");
        }

        private void githublink_clck(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Shakal1337/NoCheatsGDUI") { UseShellExecute = true });
        }

        private void otherchoice_clck(object sender, RoutedEventArgs e)
        {
            OtherChoice oc = new OtherChoice();
            oc.Show();
        }

        private void oterchoice_show(object sender, RoutedEventArgs e)
        {
            OtherChoice ch = new OtherChoice();
            ch.Show();
        }
    }
}
