using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LNS.LogApp.Controls;

namespace LNS.LogApp
{
    /// <summary>
    /// LoginForm.xaml 的交互逻辑
    /// </summary>
    public partial class LoginForm : DazzleWindow
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow frmMainWindow = new MainWindow();
            frmMainWindow.ShowDialog();
            this.Close();
        }

        private void DazzleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DazzleButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        private void DazzleButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogAppBootstrapper strapper = new LogAppBootstrapper();
            strapper.Run();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
