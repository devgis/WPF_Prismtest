using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows;

namespace LNS.LogApp.Models
{
    public class ProjectViewModel : NotificationObject
    {
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (_UserName != value)
                {
                    _UserName = value;
                    RaisePropertyChanged("UserName");
                }
            }
        }


        public ICommand ShowCommand
        {
            get
            {
                return new DelegateCommand<string>(
                    (user) =>
                    {
                        MessageBox.Show(user);
                    }, (user) =>
                    {
                        return !string.IsNullOrEmpty(user);
                    });

            }
        }
    }
}
