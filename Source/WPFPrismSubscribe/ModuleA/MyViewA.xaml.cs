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
using Microsoft.Practices.Prism.Events;

namespace ModuleA
{
    /// <summary>
    /// MyViewA.xaml 的交互逻辑
    /// </summary>
    public partial class MyViewA : UserControl
    {
        //public MyViewA()
        //{
        //    InitializeComponent();
        //    this.Loaded += (s, e) =>
        //    {
        //        textModuleA.Text = "Module A ";
        //    };
        //}
        public MyViewA(ITextProvider textProvider)
        {
            InitializeComponent();
            this.Loaded += (s, e) =>
                {
                    textModuleA.Text = string.Format("Module A {0}", textProvider.GetText());
                };

            EventAggregatorRepository.GetInstance().eventAggregator.GetEvent<GetInputMessages>().Subscribe(ReceiveMessage, ThreadOption.UIThread, true);

        }

        public void ReceiveMessage(string messageData)
        {
            this.textModuleA.Text = messageData;
        }
    }
}
