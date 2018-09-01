using Audyt_innowacyjności.DAL;
using Audyt_innowacyjności.Extensions;
using Audyt_innowacyjności.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Audyt_innowacyjności
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public string name;
        public Search()
        {
            InitializeComponent();
        }
        private void Find(object sender, RoutedEventArgs e)
        {
            using (var context = new SurveyContext())
            {

                Survey comapny = null;
                var mapper = AutoMapperConfig.GetMapper();
                if (!String.IsNullOrEmpty(input.Text))
                {
                     comapny = context.Surveys.FirstOrDefault(x => x.NazwaPrzedsiebiorstwa.ToLower() == input.Text.ToLower());
                }
                if (comapny != null)
                {
                
                    error.Content = "";
                    var model = mapper.Map<SurveyViewModel>(comapny);
                    this.NavigationService.ONavigate(new Charts(), model);
                }
                else {
                    error.Content = "Nie znaleziono!";
                }
            }
        }
    }
}
