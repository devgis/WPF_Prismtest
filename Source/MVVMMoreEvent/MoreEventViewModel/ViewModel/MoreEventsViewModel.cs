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
    public class MoreEventsViewModel
    {
        public MoreEventsViewModel()
        { 
        
        }

        private void MouseLeaveEvent(object obj)
        {
            MessageBox.Show("测试鼠标离开事件");
        }
        private void BtnClickEvent(object obj)
        {
            MessageBox.Show("测试单击事件");
        }

        public ICommand MouseLeave
        {
            get { return new MoreEventCommand(MouseLeaveEvent); }
        }
        public ICommand BtnClick
        {
            get { return new MoreEventCommand(BtnClickEvent); }
        }
    }
}
