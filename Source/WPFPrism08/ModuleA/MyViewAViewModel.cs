using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Contract;
using System.Windows.Forms;

namespace ModuleA
{
    public class MyViewAViewModel : NotificationObject
    {
        public string TextA
        {
            get;
            set;
        }

        public string TextB
        {
            get;
            set;
        }

        public ICommand ClickCommand1 { get; private set; }

        public ICommand ClickCommand2 { get; private set; }

        public MyViewAViewModel()
        {
            ClickCommand1 = new DelegateCommand<object>(OnClick1, args => true);
            ClickCommand2 = new DelegateCommand<object>(OnClick2, args => true);
            GlobalCommands.MyCompositeCommand.RegisterCommand(ClickCommand1);
            GlobalCommands.MyCompositeCommand.RegisterCommand(ClickCommand2);
        }

        public void OnClick1(object obj)
        {
            TextA = TextB;
            this.RaisePropertyChanged("TextA");
        }

        public void OnClick2(object obj)
        {
            MessageBox.Show(TextB);
        }
    }
}
