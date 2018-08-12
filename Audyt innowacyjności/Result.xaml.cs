using Audyt_innowacyjności.Extensions;
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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {

        /*List<string> result;
        string wynik;
        */
        public SurveyViewModel model { get; set; }
        public Result()
            {

            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        /*result = new List<string>();
        var model = this.NavigationService.GetData();
        var s = model;*/

        List<string> questions = new List<string>(new string[] {
            "1.	Informacje ogólne (Nazwa przedsiębiorstwa, Branża, Nr REGON, Numerem wpisu do KRS, Miasto, Od ilu lat istnieje przedsiębiorstwo):",
            "2.	Informacje o pracownikach (Liczba zatrudnionych pracowników, Przeciętnego poziomu wykształcenia pracowników, Przeciętnego stażu pracy, Przeciętny wieku zatrudnionych):",
            "3.",
            "4.",
            "5.",
            "6.",
            "7.",
            "8.",
            "9.",
            "10.",
            "11.",
            "12.",
            "13."});
            /*foreach (var p in s.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))
            {
                var i=0;
        
                var r = p.GetValue(s, null);
                if (r == null)
                    result.Add("");
                else
                {
                    
                    result.Add(r.ToString() + "\n");
                    i = i++;
                }
            }
            foreach(var ss in result)
            {
                foreach (var q in questions)
                    wynik += (q + "\n");
                wynik += ss;
            }
            InitializeComponent();
            lb.Text = wynik;*/

        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var model = this.NavigationService.GetData();
            this.NavigationService.ONavigate(new Page1(), model);
        }
    }
}
