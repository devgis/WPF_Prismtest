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

namespace ModuleB
{
    /// <summary>
    /// MyViewB.xaml 的交互逻辑
    /// </summary>
    public partial class MyViewB : UserControl
    {
        //public MyViewB()
        //{
        //    InitializeComponent();
        //    this.Loaded += (s, e) =>
        //    {
        //        textModuleA.Text = "Module B";
        //    };
        //}
        public MyViewB(ITextProvider textProvider)
        {
            InitializeComponent();
            this.Loaded += (s, e) =>
            {
                textModuleA.Text = string.Format("Module A {0}", textProvider.GetText());
            };
        }
    }
}
