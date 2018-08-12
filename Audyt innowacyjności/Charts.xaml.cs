using Audyt_innowacyjności.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfCharts;

namespace Audyt_innowacyjności
{
    /// <summary>
    /// Interaction logic for Charts.xaml
    /// </summary>
    public partial class Charts : Page
    {
    
            private readonly Random random = new Random(1234);

            public Charts()
            {
                InitializeComponent();
                Loaded += OnLoaded;
            }

            private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
            {
                DataContext = this;

                Axes = new[] { "Ilość Innowacji", "Liczba nowych pomysłów", "Zyski wdrożenia nowych wyrobów", "Zyski dzięki innowacjom", "Długość trwania cykli prac wdrożeniowych i rozwojowych", "Item 6", "Item 6", "Item 6" };

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
            var pts = new List<double>() {
            data.WprowadzoneInnowacje.Map(0, 30, 1, 5),
               data.NowePomysły.Map(0, 46, 1, 5),
               data.ZyskiNoweWyroby.Map(0, 24001, 1, 5),
               data.ZyskiInnowacjeInne.Map(0, 18001, 1, 5),
               data.DlugoscCykli.Map(0, 360, 1, 5),
               data.WydatkiInnowacyjnosc.Map(0, 20000, 1, 5),
               data.SredniaIloscPomyslow.Map(0, 2, 1, 5),
               data.SklonnoscDoRyzyka.Map(1, 5, 1, 5)
            };


            return pts;
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

            private void AddLineClick(object sender, RoutedEventArgs e)
            {
                var line = new ChartLine
                {
                    LineColor = Colors.Yellow,
                    FillColor = Color.FromArgb(128, 255, 255, 0),
                    LineThickness = 2,
                    PointDataSource = GetDataSet(),
                    Name = "Chart " + (Lines.Count + 1)
                };
                Lines.Add(line);
            }
        }
    }
    

