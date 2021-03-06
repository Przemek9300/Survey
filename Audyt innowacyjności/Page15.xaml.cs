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
    /// Logika interakcji dla klasy Page15.xaml
    /// </summary>
    public partial class Page15 : Page
    {
        public SurveyViewModel model { get; set; }

        public Page15()
        {
            this.DataContext = this.NavigationService.GetData();
            model = this.DataContext as SurveyViewModel;
            InitializeComponent();

            
        }




        private void Next(object sender, RoutedEventArgs e)
        {
            bool valid = model.IsValid ?? false;
            if (valid)
            {
                using (var context = new SurveyContext())
                {
                    context.Surveys.Add(Map.CustomMapper.Map(model));
                    context.SaveChanges();
                }

                this.NavigationService.ONavigate(new Page1(), model);
            }
            
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.ONavigate(new Page14(), model);
        }

        private void RozbudowaOferty(object sender, RoutedEventArgs e)
        {
            model.RozbudowaOferty = true;
        }

        private void LepszaPromocja(object sender, RoutedEventArgs e)
        {
            model.LepszaPromocja = true;
        }

        private void ModernizacjaZaplecza(object sender, RoutedEventArgs e)
        {
            model.ModernizacjaZaplecza = true;

        }

        private void NoweOprogramowanie(object sender, RoutedEventArgs e)
        {
            model.NoweOprogramowanie = true;

        }

        private void InneDzialania(object sender, RoutedEventArgs e)
        {
            model.InneDzialania = true;


        }
    }
}
