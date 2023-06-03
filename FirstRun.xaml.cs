using System;
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
using System.Windows.Shapes;
using Microsoft.VisualBasic;
using Microsoft.Win32;


namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Логика взаимодействия для FirstRun.xaml
    /// </summary>
    public partial class FirstRun : Window
    {
        OpenFileDialog _dlg = new OpenFileDialog();
        public FirstRun()
        {
            InitializeComponent();
            this.Topmost = true;
            if (Settings.Default.DebugMode == true) 
            {
                this.DebugButton.Visibility = Visibility.Visible;
            }
            else 
            {
                this.DebugButton.Visibility = Visibility.Hidden;
            }

        }

        private void InfoShow(object sender, RoutedEventArgs e)
        {
            MessageBox.Show
                (
                "By shakal" +
                "\nconntact:" +
                "\nemail: InS.Network.Help@outlook.com" +
                "\ntelegram: @shakalofff" +
                "\nInS 2020-2023 ©",
                "Info",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
        }

        private void bypasspath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string pathbypass = _dlg.FileName;
            if ( ress != null ) {
                _ = pathbypass;
                Settings.Default.GDHMMoveSettingsByPass = pathbypass;
                Settings.Default.Save();
            
            }
        }

        private void playerpath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string pathplayer = _dlg.FileName;
            if ( ress != null ) {
                _ = pathplayer;
                Settings.Default.GDHMMoveSettingsPlayer = pathplayer;
                Settings.Default.Save();
            }
        }

        private void globalpath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string pathglobal = _dlg.FileName;
            if ( ress != null )
            {
                _ = pathglobal;
                Settings.Default.GDHMMoveSettingsGlobal = pathglobal;
                Settings.Default.Save();
            }
        }

        private void gdbotpath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string pathgdbot = _dlg.FileName;
            if ( ress != null )
            {
                _ = pathgdbot;
                Settings.Default.GDBotMoveSettings = pathgdbot;
            }
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Settings.Default.FirstRun = false;
            Settings.Default.Save();
            FirstRun firstRun = new FirstRun();
            firstRun.Hide();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            Settings.Default.GDBotMoveSettings = "";
            Settings.Default.GDHMMoveSettingsByPass = "";
            Settings.Default.GDHMMoveSettingsCore = "";
            Settings.Default.GDHMMoveSettingsCreator = "";
            Settings.Default.GDHMMoveSettingsGlobal = "";
            Settings.Default.GDHMMoveSettingsPlayer = "";
            Settings.Default.GDHMMoveSettingsvVriables = "";
            Settings.Default.Save();
        }

        private void corepath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string pathcore = _dlg.FileName;
            if ( ress != null )
            {
                _ = pathcore;
               Settings.Default.GDHMMoveSettingsCore = pathcore;
               Settings.Default.Save();
            }
        }

        private void creatorpath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string pathcreator = _dlg.FileName;
            if (ress != null) {
                _ = pathcreator;
                Settings.Default.GDHMMoveSettingsCreator = pathcreator;
                Settings.Default.Save();
            }
        }

        private void variablespath(object sender, RoutedEventArgs e)
        {
            Nullable<bool> ress = _dlg.ShowDialog();
            string variablespath = _dlg.FileName;
            if ( ress != null )
            {
                _ = variablespath;
                Settings.Default.GDHMMoveSettingsvVriables = variablespath;
                Settings.Default.Save();
            }
        }

        private void DebugActived(object sender, MouseWheelEventArgs e)
        {
            this.DebugButton.Visibility = Visibility.Visible;
            MessageBox.Show
                (
                "Debug Active only this window",
                "",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
                );
        }

        private void DubugWindow(object sender, RoutedEventArgs e)
        {
            debug db = new debug();
            db.Show();
        }
    }
}
