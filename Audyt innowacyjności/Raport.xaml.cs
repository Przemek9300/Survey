﻿using Audyt_innowacyjności.ViewModel;
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
    /// Interaction logic for Raport.xaml
    /// </summary>
    public partial class Raport : Page
    {
        public Raport(string result, SurveyViewModel data)
        {
            InitializeComponent();
            this.DataContext = data;
            r.Text = result;
        }
    }
}
