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

namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string MainFloder = Settings.Default.MainFloder;
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


        }

        private void gdbotoffon(object sender, RoutedEventArgs e)
        {
            File.Move(Settings.Default.GDBotMoveSettings, MainFloder );
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
        }
    }
}
