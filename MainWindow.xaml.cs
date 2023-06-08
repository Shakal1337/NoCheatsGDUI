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

namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            bool MainDirectorySearch = File.Exists(@"C:\ProgramData\InS\NoCheatsGD(UI)\result");
            InitializeComponent();
            if (MainDirectorySearch == true) { }
            else
            {
                Directory.CreateDirectory(@"C:\ProgramData\InS\NoCheatsGD(UI)\result");
            }

            //if (Settings.Default.FirstRun == true)
            //{
            //    FirstRun firstRun = new FirstRun();
            //    firstRun.Show();
            //}
            //else
            //{
            //    InitializeComponent();
            //}


        }


        private void backlightoff_MouseEnter (object sender, MouseEventArgs e)
        {
            ((Button)sender).IsHitTestVisible = false;
        }

    }
}
