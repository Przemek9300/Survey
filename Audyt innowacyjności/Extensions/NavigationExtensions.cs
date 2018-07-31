using Audyt_innowacyjności.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Audyt_innowacyjności.Extensions
{
    public static class NavigationExtensions
    {
        private static SurveyViewModel _navigationData = null;

        public static void ONavigate(this NavigationService service, Page page, SurveyViewModel data)
        {
            _navigationData = data;
            service.Navigate(page);
        }

        public static SurveyViewModel GetData(this NavigationService service)
        {
            SurveyViewModel data = _navigationData;
            
            return data;
        }
    }
}
