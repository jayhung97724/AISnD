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
using System.Windows.Shapes;

namespace el.cl
{
    /// <summary>
    /// Form_Login.xaml 的互動邏輯
    /// </summary>
    public partial class Form_Login : Window
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Opacity = 100;
        }
    }
}
