using Audyt_innowacyjności.Extensions;
using Audyt_innowacyjności.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media;

using WpfCharts;

namespace Audyt_innowacyjności
{
    /// <summary>
    /// Interaction logic for Charts.xaml
    /// </summary>
    public partial class Charts : Page
    {
        public List<double> Pts { get; set; }
        
        private readonly Random random = new Random(1234);

            public Charts()
            {
                InitializeComponent();
                Loaded += OnLoaded;
            }

            private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
            {
                DataContext = this;
                
         
                 
        Axes = new[] { "Ilość Innowacji", "Liczba nowych pomysłów", "Zyski wdrożenia nowych wyrobów", "Zyski dzięki innowacjom", "Długość trwania cykli prac wdrożeniowych i rozwojowych", "Wysokość wydatków przeznaczonych na innowacyjność", "Średnia ilość pomysłów na jednego pracownika", "Skłonność do podejmowania ryzyka" };

                Lines = new ObservableCollection<ChartLine> {
                                                            new ChartLine {
                                                                              LineColor = Colors.Red,
                                                                              FillColor = Color.FromArgb(128, 255, 0, 0),
                                                                              LineThickness = 2,
                                                                              PointDataSource = GetDataSet(),
                                                                              Name = "Chart 1"
                                                                          }
                                                 
                                                        };


            }

        public List<double> GetDataSet()
        {
            var data = this.NavigationService.GetData();
            Pts = new List<double>() {
            data.WprowadzoneInnowacje.Map(0, 30, 1, 5),
               data.NowePomysły.Map(0, 46, 1, 5),
               data.ZyskiNoweWyroby.Map(0, 24001, 1, 5),
               data.ZyskiInnowacjeInne.Map(0, 18001, 1, 5),
               data.DlugoscCykli.Map(0, 360, 1, 5),
               data.WydatkiInnowacyjnosc.Map(0, 20000, 1, 5),
               data.SredniaIloscPomyslow.Map(0, 2, 1, 5),
               data.SklonnoscDoRyzyka.Map(1, 5, 1, 5)
            };


            return Pts;
        }
            public List<double> GenerateRandomDataSet(int nmbrOfPoints)
            {
                var pts = new List<double>(nmbrOfPoints);
                for (var i = 0; i < nmbrOfPoints; i++)
                {
                    pts.Add(random.NextDouble());
                }
                return pts;
            }

            public string[] Axes { get; set; }
            public ObservableCollection<ChartLine> Lines { get; set; }

        private void Check(object sender, RoutedEventArgs e)
        {
            string comments = "";
            if (Pts[0] == 1)
                comments += Comments.result[0];
            if (Pts[0] == 2 || Pts[0] == 3)
                comments += Comments.result[1];
            if (Pts[0] >= 4)
                comments += Comments.result[2];

       
            if (Pts[1] == 1)
                comments += Comments.result[3]+ Environment.NewLine;
            if (Pts[1] == 2 || Pts[1] == 3)
                comments += Comments.result[4] + Environment.NewLine;
            if (Pts[1] >= 4)
                comments += Comments.result[5] + Environment.NewLine;

            if (Pts[2] == 1)
                comments += Comments.result[6] + Environment.NewLine;
            if (Pts[2] == 2 || Pts[2] == 3)
                comments += Comments.result[7] + Environment.NewLine;
            if (Pts[2] >= 4)
                comments += Comments.result[8] + Environment.NewLine;


            if (Pts[3] == 1)
                comments += Comments.result[9] + Environment.NewLine;
            if (Pts[3] == 2 || Pts[3] == 3)
                comments += Comments.result[10] + Environment.NewLine;
            if (Pts[3] >= 4)
                comments += Comments.result[11] + Environment.NewLine;


            if (Pts[4] == 1)
                comments += Comments.result[12] + Environment.NewLine;
            if (Pts[4] == 2 || Pts[4] == 3)
                comments += Comments.result[13] + Environment.NewLine;
            if (Pts[4] >= 4)
                comments += Comments.result[14] + Environment.NewLine;


            if (Pts[5] == 1)
                comments += Comments.result[15] + Environment.NewLine;
            if (Pts[5] == 2 || Pts[5] == 3)
                comments += Comments.result[16] + Environment.NewLine;
            if (Pts[5] >= 4)
                comments += Comments.result[17] + Environment.NewLine;

            if (Pts[6] == 1)
                comments += Comments.result[18] + Environment.NewLine;
            if (Pts[6] == 2 || Pts[6] == 3)
                comments += Comments.result[19] + Environment.NewLine;
            if (Pts[6] >= 4)
                comments += Comments.result[20] + Environment.NewLine;


            if (Pts[7] == 1)
                comments += Comments.result[21] + Environment.NewLine;
            if (Pts[7] == 2 || Pts[7] == 3)
                comments += Comments.result[22] + Environment.NewLine;
            if (Pts[7] >= 4)
                comments += Comments.result[23] + Environment.NewLine;





            this.NavigationService.Navigate(new Raport(comments));
            }
        }
    }
    

