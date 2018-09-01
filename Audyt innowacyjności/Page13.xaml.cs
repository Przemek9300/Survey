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
using static Audyt_innowacyjności.Survey;

namespace Audyt_innowacyjności
{
    /// <summary>
    /// Logika interakcji dla klasy Page13.xaml
    /// </summary>
    public partial class Page13 : Page
    {
        public SurveyViewModel model { get; set; }
        

        public Page13()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();
            


        }




        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page14(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page12(), model);
        }


        private void PraceBadawczeTAK(object sender, RoutedEventArgs e)
        {
            model.PraceBadawcze = PraceBadawcze.TAK;
        }

        private void PraceBadawczeNIE(object sender, RoutedEventArgs e)
        {
            model.PraceBadawcze = PraceBadawcze.NIE;

        }

        private void PraceBadawczePLANUJE(object sender, RoutedEventArgs e)
        {
            model.PraceBadawcze = PraceBadawcze.PLANUJE;

        }

        private void KoloLubOrganizacjaTAK(object sender, RoutedEventArgs e)
        {
            model.KoloLubOrganizacja = true;
        }

        private void KoloLubOrganizacjaNIE(object sender, RoutedEventArgs e)
        {
            model.KoloLubOrganizacja = false;

        }

        private void CertyfikatJakosciTAK(object sender, RoutedEventArgs e)
        {
            model.CertyfikatJakosci = true;
        }

        private void CertyfikatJakosciNIE(object sender, RoutedEventArgs e)
        {
            model.CertyfikatJakosci = false;
        }

        private void PomiarStopniaSwiadczonychUslugTAK(object sender, RoutedEventArgs e)
        {
            model.PomiarStopniaSwiadczonychUslug = true;
        }

        private void PomiarStopniaSwiadczonychUslugNIE(object sender, RoutedEventArgs e)
        {
            model.PomiarStopniaSwiadczonychUslug = false;

        }
    }
}
