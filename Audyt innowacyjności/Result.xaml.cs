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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        int i = 0;
        List<string> result;
        string wynik;
        public Result()
        {
            
            result = new List<string>();
            var model = this.NavigationService.GetData();
            var s = model;
            foreach (var p in s.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))
            {
                var r = p.GetValue(s, null);
                if (r == null)
                    result.Add("");
                else
                    result.Add(r.ToString() + "\n");
            }
            foreach(var  ss in result)
            {
                wynik += ss;
            }
            InitializeComponent();
            lb.Text = wynik;

        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var model = this.NavigationService.GetData();
            this.NavigationService.ONavigate(new Page1(), model);
        }
    }
}
