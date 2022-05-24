using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1 {
	public class Window1ViewModel {

		public ICommand ButtonCommand {
			get {
				return new DelegateCommand<string>((str) => {
					MessageBox.Show("Button's parameter:"+str);
				});
			}
		}

		public ICommand ButtonCommand2 {
			get {
				return new DelegateCommand<Button>((button) => {
					button.Content = "Clicked";
					MessageBox.Show("Button");
				});
			}
		}
	}
}
