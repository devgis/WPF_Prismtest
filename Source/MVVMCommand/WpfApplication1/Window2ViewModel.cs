using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1 {
	public class Window2ViewModel {

		public ICommand Command1 {
			get {
				return new DelegateCommand<string>((str) => {
					MessageBox.Show("Command1 with parameter:"+str);
				});
			}
		}

		public ICommand Command2 {
			get {
				return new DelegateCommand<Button>((button) => {
					Point p = Mouse.GetPosition(button);
					button.Content = string.Format("{0},{1}", p.X, p.Y);
				});
			}
		}
	}
}
