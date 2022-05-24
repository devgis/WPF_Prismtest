using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfAppMvvmTest
{
    class Model : NotificationObject
    {
        private string _wpf = "WPF";

        public string WPF
        {
            get { return _wpf; }
            set
            {
                _wpf = value;
                this.RaisePropertyChanged("WPF");
            }
        }

        public void Copy(object obj)
        {
            this.WPF += " WPF";
        }

        public void GetData()
        {
            
        }

    }
}
