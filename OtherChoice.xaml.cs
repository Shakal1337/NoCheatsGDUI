﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Логика взаимодействия для OtherChoice.xaml
    /// </summary>
    public partial class OtherChoice : Window
    {
        public Source src = new Source();
        public OtherChoice()
        {
            InitializeComponent();
            //MessageBox.Show($"{menu.Items}");

        }

        public void selectelement() 
        { 
            Settings.Default.AnyElementSelect = true;
            Settings.Default.Save();
        }

        public void unselectalement()
        {
            Settings.Default.AnyElementSelect = false;
            Settings.Default.Save();
        
        }

        private void bypassoff(object sender, RoutedEventArgs e)
        {
            File.Move(
                Settings.Default.GDHMMoveSettingsByPass ,
                src.MainFloder + @"\" + src.ModeName[0]               
               );
            selectelement();
        }

        private void coreoff(object sender, RoutedEventArgs e)
        {
            File.Move(
                Settings.Default.GDHMMoveSettingsCore,
                src.MainFloder + @"\" + src.ModeName[1]
                );
            selectelement();
        }

        private void globaloff(object sender, RoutedEventArgs e)
        {
            File.Move(
                Settings.Default.GDHMMoveSettingsGlobal,
                src.MainFloder + @"\" + src.ModeName[2] 
                );
            selectelement();
        }

        private void playeroff(object sender, RoutedEventArgs e)
        {
            File.Move(
                Settings.Default.GDHMMoveSettingsPlayer,
                src.MainFloder + @"\" + src.ModeName[3]
                );
            selectelement();
        }

        private void varioff(object sender, RoutedEventArgs e)
        {
            File.Move(
                Settings.Default.GDHMMoveSettingsvVriables,
                src.MainFloder + @"\" + src.ModeName[4]
                );
            selectelement();
        }

        private void creatoroff(object sender, RoutedEventArgs e)
        {
            File.Move(
                Settings.Default.GDHMMoveSettingsCreator,
                src.MainFloder + @"\" + src.ModeName[5]
                );
            selectelement();
        }






        private void bypasson(object sender, RoutedEventArgs e)
        {
            File.Move(
                src.MainFloder + @"\" + src.ModeName[0],
                Settings.Default.GDHMMoveSettingsByPass
                );
            unselectalement();
        }

        private void coreon(object sender, RoutedEventArgs e)
        {
            File.Move(
                src.MainFloder + @"\" + src.ModeName[1],
                Settings.Default.GDHMMoveSettingsCore
                );
            unselectalement();
        }

        private void globalon(object sender, RoutedEventArgs e)
        {
            File.Move(
                src.MainFloder + @"\" + src.ModeName[2],
                Settings.Default.GDHMMoveSettingsGlobal
                );
            unselectalement();
        }

        private void playeron(object sender, RoutedEventArgs e)
        {
            File.Move(
                src.MainFloder + @"\" + src.ModeName[3],
                Settings.Default.GDHMMoveSettingsPlayer
                );
            unselectalement();
        }

        private void varion(object sender, RoutedEventArgs e)
        {
            File.Move(
                src.MainFloder + @"\" + src.ModeName[4],
                Settings.Default.GDHMMoveSettingsvVriables
                );
            unselectalement();
        }

        private void creatoron(object sender, RoutedEventArgs e)
        {
            File.Move(
                src.MainFloder + @"\" + src.ModeName[5],
                Settings.Default.GDHMMoveSettingsCreator
                );
            unselectalement();
        }
    }
}
