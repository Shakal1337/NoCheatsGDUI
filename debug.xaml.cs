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
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Configuration;

namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Логика взаимодействия для debug.xaml
    /// </summary>
    public partial class debug : Window
    {
        public debug()
        {
            InitializeComponent();
            if (Settings.Default.DebugMode == true)
            {
                this.ActiveDubug.IsChecked = true;
            }
            else 
            {   
                this.ActiveDubug.IsChecked = false;
            }
        }

        private void ActiveDebugModeFull(object sender, RoutedEventArgs e)
        {
            Settings.Default.DebugMode = true;
            Settings.Default.Save();
            this.wairnongdebug.Visibility = Visibility.Hidden;
            this.activedubugmessage.Visibility = Visibility.Visible;
        }

        private void DebugModeDiactived(object sender, RoutedEventArgs e)
        {
            Settings.Default.DebugMode = false;
            Settings.Default.Save();
            this.wairnongdebug.Visibility = Visibility.Visible;
            this.activedubugmessage.Visibility = Visibility.Hidden;
        }

        private void AllSettingsView_(object sender, RoutedEventArgs e)
        {
            MessageBox.Show
                (
                $"Main floder: {Settings.Default.MainFloder}" +
                $"\nPath to mods: {Settings.Default.MainFloderResalutFloder}" +
                $"\npath to gdbot: {Settings.Default.GDBotMoveSettings}" +
                $"\npath to gdhm bypass: {Settings.Default.GDHMMoveSettingsByPass}" +
                $"\npath to gdhm player: {Settings.Default.GDHMMoveSettingsPlayer}" +
                $"\npath to gdhm core: {Settings.Default.GDHMMoveSettingsCore}" +
                $"\npath to gdhm creator: {Settings.Default.GDHMMoveSettingsCreator}" +
                $"\npath to gdhm vriables: {Settings.Default.GDHMMoveSettingsvVriables}",
                "",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
        }

        private void AllSettingsView(object sender, RoutedEventArgs e)
        {
            MessageBox.Show
                (
                $"Main floder: {Settings.Default.MainFloder}" +
                $"\nPath to mods: {Settings.Default.MainFloderResalutFloder}" +
                $"\npath to gdbot: {Settings.Default.GDBotMoveSettings}" +
                $"\npath to gdhm bypass: {Settings.Default.GDHMMoveSettingsByPass}" +
                $"\npath to gdhm player: {Settings.Default.GDHMMoveSettingsPlayer}" +
                $"\npath to gdhm core: {Settings.Default.GDHMMoveSettingsCore}" +
                $"\npath to gdhm creator: {Settings.Default.GDHMMoveSettingsCreator}" +
                $"\npath to gdhm vriables: {Settings.Default.GDHMMoveSettingsvVriables}" +
                $"\ndebug mod status: {Settings.Default.DebugMode}" +
                $"\nfirst run: {Settings.Default.FirstRun}",
                "",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
        }

        private void OpenMainFloder(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\1337\Desktop\dev");
        }

        private void OpenModsFloder(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\1337\Desktop\dev");
        }

        private void ResetAll(object sender, RoutedEventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.Save();
        }

        private void ResetPath(object sender, RoutedEventArgs e)
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
    }
}
