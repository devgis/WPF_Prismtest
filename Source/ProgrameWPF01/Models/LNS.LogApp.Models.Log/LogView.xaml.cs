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
using LNS.LogApp.Contract;

namespace LNS.LogApp.Models
{
    public partial class LogView : UserControl
    {
        public LogView(ITextProvider textProvider)
        {
            InitializeComponent();
            this.Loaded += (s, e) =>
            {
                textModuleA.Text = string.Format("Module B {0}", textProvider.GetText());
            };
        }
    }
}
