using Audyt_innowacyjności.DAL;
using Audyt_innowacyjności.Extensions;
using Audyt_innowacyjności.Mapper;
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
    /// Logika interakcji dla klasy Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page9()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            using (var context = new SurveyContext())
            {
                context.Surveys.Add(AutoMapper.Map(model));
                context.SaveChanges();
            }
        }




        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page10(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page8(), model);
        }

        private void Pracownicy(object sender, RoutedEventArgs e)
        {
            model.Pracownicy = true;
        }

        private void Konkurenci(object sender, RoutedEventArgs e)
        {
            model.Konkurenci = true;
        }

        private void Klienci(object sender, RoutedEventArgs e)
        {
            model.Klienci = true;
        }

        private void FirmyDoradcze(object sender, RoutedEventArgs e)
        {
            model.FirmyDoradcze = true;
        }

        private void Uczelnie(object sender, RoutedEventArgs e)
        {
            model.Uczelnie = true;
        }

        private void Placowki(object sender, RoutedEventArgs e)
        {
            model.Placowki = true;
        }

        private void Inne(object sender, RoutedEventArgs e)
        {
            model.Inne = true;
        }
    }
}
