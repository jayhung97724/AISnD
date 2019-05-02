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

namespace el.cl
{
    /// <summary>
    /// createDiet_root.xaml 的互動邏輯
    /// </summary>
    public partial class createDiet_root : UserControl
    {
        public createDiet_root()
        {
            InitializeComponent();
        }

        private void btn_month_Click(object sender, RoutedEventArgs e)
        {
            cd.Visibility = Visibility.Visible;
            cd_week.Visibility = Visibility.Hidden;
        }

        private void btn_week_Click(object sender, RoutedEventArgs e)
        {
            cd.Visibility = Visibility.Hidden;
            cd_week.Visibility = Visibility.Visible;
        }
    }
}
