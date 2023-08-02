using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для SettingsWindw.xaml
    /// </summary>
    public partial class SettingsWindw : Window
    {
        public SettingsWindw()
        {
            InitializeComponent();
        }

        private void first_window_clck(object sender, RoutedEventArgs e)
        {
            FirstRun fr = new FirstRun();
            fr.Show();
        }

        private void on_offAniStartup_clck(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            if (mainWindow.csa_name.ControlStoryboardOption == ControlStoryboardOption.Play)
            {
                mainWindow.csa_name.ControlStoryboardOption = ControlStoryboardOption.Stop;
            }

            else
                mainWindow.csa_name.ControlStoryboardOption = ControlStoryboardOption.Play;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Shakal1337/NoCheatsGDUI") { UseShellExecute = true });
        }

        private void help_show_butt(object sender, RoutedEventArgs e)
        {
            Help_window hw = new Help_window();
            hw.Show();
        }
    }
}
