using Audyt_innowacyjności.DAL;
using Audyt_innowacyjności.Extensions;
using Audyt_innowacyjności.Map;
using Audyt_innowacyjności.ViewModel;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {

        public SurveyViewModel model { get; set; }

        public Page3()
        {
            InitializeComponent();
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;

            

        }

        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page4(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page2(), model);
        }
    }
}
