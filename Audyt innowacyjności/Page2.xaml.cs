using Audyt_innowacyjności.DAL;
using Audyt_innowacyjności.Extensions;
using Audyt_innowacyjności.Mapper;
using Audyt_innowacyjności.ViewModel;

using System.Windows;
using System.Windows.Controls;


namespace Audyt_innowacyjności
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page2()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        }




        private void Next(object sender, RoutedEventArgs e)
        {


                this.NavigationService.ONavigate(new Page3(), model);

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page1(), model);
        }
    }
}
