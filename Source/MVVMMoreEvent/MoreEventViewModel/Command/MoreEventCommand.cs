using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MoreEventViewModel
{
    public class MoreEventCommand:ICommand
    {
        Action<object> _action;
        public MoreEventCommand(Action<object> ac)
        {
            _action = ac;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_action != null)
                _action(parameter);
        }
    }
}
