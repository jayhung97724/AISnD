using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace el.cl
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
        }

        private void Menu_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //leftMenu.Visibility = leftMenu.IsEnabled ? Visibility.Visible : Visibility.Hidden;
        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //until we had a StaysOpen glag to Drawer, this will help with scroll bars
            var dependencyObject = Mouse.Captured as DependencyObject;
            while (dependencyObject != null)
            {
                if (dependencyObject is ScrollBar) return;
                dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
            }

            MenuToggleButton.IsChecked = false;
        }

        private void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //UIElement_OnPreviewMouseLeftButtonUp(sender, e);
        }

        private void btn_菜單_Click(object sender, RoutedEventArgs e)
        {
            if (cd.Visibility == Visibility.Hidden)
                cd.Visibility = Visibility.Visible;
            else
                cd.Visibility = Visibility.Hidden;
        }

        private void Form_Main_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Visibility = Visibility.Hidden;
            Form_Login from_login = new Form_Login();
            from_login.Owner = this;
            from_login.Show();
        }

        private void Login_BasicInfo_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
