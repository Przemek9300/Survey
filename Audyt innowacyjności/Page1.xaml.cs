using Audyt_innowacyjności.Extensions;
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

namespace Audyt_innowacyjności
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            
            InitializeComponent();
        }

        private void Btn1(object sender, RoutedEventArgs e)
        {
            var model = this.NavigationService.GetData();
            this.NavigationService.ONavigate(new Page2(),model);
        }
        
        private void Btn3(object sender, RoutedEventArgs e)
        {
            var model = this.NavigationService.GetData();

            this.NavigationService.Navigate(new Charts());
        }
    }
}
