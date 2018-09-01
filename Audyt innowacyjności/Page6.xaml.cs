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
    /// Logika interakcji dla klasy Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page6()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        }




        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page7(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page5(), model);
        }

        private void KoordynacjaPracyTAK(object sender, RoutedEventArgs e)
        {
            model.KoordynacjaPracy = true;
        }

        private void KoordynacjaPracyNIE(object sender, RoutedEventArgs e)
        {
            model.KoordynacjaPracy = false;
        }

        private void PracaZespolowaTAK(object sender, RoutedEventArgs e)
        {
            model.PracaZespolowa = true;
        }

        private void PracaZespolowaNIE(object sender, RoutedEventArgs e)
        {
            model.PracaZespolowa = false;
        }



        private void WsparcieInnowacjiTAK(object sender, RoutedEventArgs e)
        {
            model.WsparcieInnowacji = true;
        }

        private void WsparcieInnowacjiNIE(object sender, RoutedEventArgs e)
        {
            model.WsparcieInnowacji = false;
        }
    }
}
