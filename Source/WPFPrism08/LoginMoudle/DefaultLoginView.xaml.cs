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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Contract;

namespace LoginMoudle
{
    public delegate void RoutedEventHandler(object sender, LoginSucessedEventArgs e);
    /// <summary>
    /// DefaultLoginView.xaml 的交互逻辑
    /// </summary>
    public partial class DefaultLoginView : UserControl
    {
        public event RoutedEventHandler LoginSucessed;
        //public delegate void LoginSucessed(object sender, LoginSucessedEventArgs e);
        //public event EventHandler LoginSucessed;
        //public delegate LoginSucessed<LoginSucessedEventArgs>;
        //public LoginSucessedEvent LoginSucessed
        //{
        //    get;
        //    set;
        //}
        public DefaultLoginView()
        {
            InitializeComponent();
            textModuleA.Text = "loginmodule";
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginSucessed != null)
            {
                LoginSucessed(null, new LoginSucessedEventArgs() { Message = textModuleA.Text });
                //MessageBox.Show("成功！");
            }
        }
    }
}
