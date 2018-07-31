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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SurveyViewModel model { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new SurveyViewModel();
            



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.ONavigate(new Page1(), (SurveyViewModel)this.DataContext);
        }
    }
}
