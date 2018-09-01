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
    /// Logika interakcji dla klasy Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page10()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        }




        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page11(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page9(), model);
        }

        private void PoszerzenieOferty(object sender, RoutedEventArgs e)
        {
            model.PoszerzenieOferty = true;
        }

        private void UlatwienieDzialanProdukcyjnych(object sender, RoutedEventArgs e)
        {
            model.UlatwienieDzialanProdukcyjnych = true;
        }

        private void PoprawaJakosciUslug(object sender, RoutedEventArgs e)
        {
            model.PoprawaJakosciUslug = true;
        }

        private void WzrostPrestizu(object sender, RoutedEventArgs e)
        {
            model.WzrostPrestizu = true;
        }

        private void NoweKontakty(object sender, RoutedEventArgs e)
        {
            model.NoweKontakty = true;
        }

        private void ZmniejszenieKosztow(object sender, RoutedEventArgs e)
        {
            model.ZmniejszenieKosztow = true;
        }

        private void OdpowiedziDoKlientow(object sender, RoutedEventArgs e)
        {
            model.OdpowiedziDoKlientow = true;
        }
    }
}
