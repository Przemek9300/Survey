﻿using Audyt_innowacyjności.DAL;
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
    /// Logika interakcji dla klasy Page14.xaml
    /// </summary>
    public partial class Page14 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page14()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        }




        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page15(), model);
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page13(), model);
        }

        private void PerpektywaRozwojuWSCHODZACY(object sender, RoutedEventArgs e)
        {
            model.PerpektywaRozwoju = PerpektywaRozwoju.wschodzący;
        }

        private void PerpektywaRozwojuSCHYLKOWY(object sender, RoutedEventArgs e)
        {
            model.PerpektywaRozwoju = PerpektywaRozwoju.schyłkowy;

        }

        private void PerpektywaRozwojuSTABILNY(object sender, RoutedEventArgs e)
        {
            model.PerpektywaRozwoju = PerpektywaRozwoju.stabilny;

        }

        private void PerpektywaRozwojuNIESTABILNY(object sender, RoutedEventArgs e)
        {
            model.PerpektywaRozwoju = PerpektywaRozwoju.niestabilny;

        }
    }
}
