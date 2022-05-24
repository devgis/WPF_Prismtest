using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Commands;

namespace Contract
{
    public static class GlobalCommands
    {
        //public static CompositeCommand MyCompositeCommand = new CompositeCommand(true);
        public static CompositeCommand MyCompositeCommand = new CompositeCommand();

        //public DelegateCommand<object> ClickCommand = new DelegateCommand<object>(OnClick, arg => true);
    }
}
