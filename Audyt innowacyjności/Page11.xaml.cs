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
    /// Logika interakcji dla klasy Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page11()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        }




        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page12(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page10(), model);
        }

        private void PomiarStopniaInnowacyjnosciTAK(object sender, RoutedEventArgs e)
        {
            model.PomiarStopniaInnowacyjnosci = true;
        }

        private void PomiarStopniaInnowacyjnosciNIE(object sender, RoutedEventArgs e)
        {
            model.PomiarStopniaInnowacyjnosci = false;
        }
    }
}
