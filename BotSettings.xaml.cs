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
using Microsoft.Win32;

namespace NoCheatsGD_UI_
{
    /// <summary>
    /// Логика взаимодействия для BotSettings.xaml
    /// </summary>
    public partial class BotSettings : Window
    {
        public BotSettings()
        {
            InitializeComponent();
        }

        private void GdBotWrite(object sender, TextChangedEventArgs e)
        {
           TextBox textBox = (TextBox)sender;
           Settings.Default.GDBotName = textBox.Text;
            Settings.Default.Save();
            Debug.WriteLine(Settings.Default.GDBotName);
            Debug.WriteLine(Settings.Default.GDBotMoveSettings);
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
