using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WpfAppMvvmTest
{
    class ViewModel
    {
        public DelegateCommand CopyCmd { get; set; }
        public Model model { get; set; }
        private DelegateCommand m_saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (m_saveCommand == null)
                {
                    m_saveCommand = new DelegateCommand(param => this.Save());
                }
                return m_saveCommand;
            }
        }

        public ViewModel(string name)
        {
            this.model = new Model();
            this.CopyCmd = new DelegateCommand();
            this.CopyCmd.ExecuteCommand = new Action<object>(this.model.Copy);
        }
        private void Save()
        {
            model.WPF += " 保存成功";
        }
        

    }
}
