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
        public SurveyViewModel Data { get; set; }
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
           Data = this.NavigationService.GetData();
            Pts = new List<double>() {
            Data.WprowadzoneInnowacje.Map(0, 30, 1, 5),
               Data.NowePomysły.Map(0, 46, 1, 5),
               Data.ZyskiNoweWyroby.Map(0, 24001, 1, 5),
               Data.ZyskiInnowacjeInne.Map(0, 18001, 1, 5),
               Data.DlugoscCykli.Map(0, 360, 1, 5),
               Data.WydatkiInnowacyjnosc.Map(0, 20000, 1, 5),
               Data.SredniaIloscPomyslow.Map(0, 2, 1, 5),
               Data.SklonnoscDoRyzyka.Map(1, 5, 1, 5)
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
            double score = 0;
            foreach (var item in Pts)
            {
                score += item;
            }
            score /= Pts.Count;
            comments += "Średnia ocena innowacyjności:" + String.Format("{0:F2}", score) + "\n";
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
            
            if (Data.PraceBadawcze == PraceBadawcze.TAK)
                comments += "Jeśli firma przeznacza na badania i rozwój pewien procent zysku, otwiera sobie możliwość ciągłego rozwoju i udoskonalenia procesów twórczych, dzięki czemu organizacja może lepiej funkcjonować. Nakłady przeznaczone na innowacyjność przynoszą skutek w postaci wprowadzania patentów oraz ochroną zdobytej wiedzy. Warto wciąż gospodarować kapitał by nadal się rozwijać, a nie tylko poprzestawać na zdobytych już patentach." + Environment.NewLine;
            else if (Data.PraceBadawcze == PraceBadawcze.NIE)
                comments += "Jeśli firma nie przeznacza na badania i rozwój pewien procent zysku, zamyka sobie możliwość ciągłego rozwoju i udoskonalenia procesów twórczych, przez co organizacja nie może lepiej funkcjonować. Brak nakładów na innowacyjność przynoszą skutek w postaci  braku patentów. Firma powinna rozpocząć prace badawczo rozwojowe, które w przyszłości powinny przynieść nowe patenty." + Environment.NewLine;
            else
                comments += "Dobrze, że firma planuje przeznaczyć nakłady na prace badawczo-rozwojowe.Jest to bardzo ważne, ponieważ gdy firma przeznacza na badania i rozwój pewien procent zysku, otwiera sobie możliwość ciągłego rozwoju i udoskonalenia procesów twórczych, dzięki czemu organizacja może lepiej funkcjonować. Nakłady przeznaczone na innowacyjność mogą przynieść skutek w postaci wprowadzania patentów oraz ochrony zdobytej wiedzy.Warto wciąż gospodarować kapitał by się rozwijać." + Environment.NewLine;

            if (Data.PomiarStopniaInnowacyjnosci == true)
                comments += "Bardzo dużym plusem jest fakt iż przedsiębiorstwo we własnym zakresie prowadzi działanie związane z pomiarem stopnia innowacyjności. Oznacza to, że innowacyjność stała się w firmie bardzo ważnym czynnikiem. Stosowe wskaźniki w firmie: w punkcie 8." + Environment.NewLine;
            else
                comments += "Firma nie prowadzi we własnym zakresie pomiaru stopnia innowacyjności, co pokazuje, że innowacyjność nie jest najważniejszym czynnikiem w „życiu” firmy.  Przedsiębiorstwo innowacyjne powinno stosować wskaźniki innowacyjności. W przyszłości należy wprowadzić w życie któryś z poniższych wskaźników:" + Environment.NewLine+"- Liczba nowych produktów w 3 ostatnich latach;" + Environment.NewLine + "-Procentowa wielkość sprzedaży(generowana przez nowe produkty);" + Environment.NewLine + "-Procentowa wielkość zysków generowanych przez nowe produkty;" + Environment.NewLine + "-Sprzedaż z tytułu innowacji innych niż nowe produkty;" + Environment.NewLine + "-Zyski z tytułu innowacji innych niż nowe produkty;" + Environment.NewLine + "-Liczba nowych produktów generowanych rocznie;-Liczba zgłoszeń patentowych w ostatnich 3 latach;" + Environment.NewLine + "-Liczba planowanych projektów w najbliższych 3 latach.";
            this.NavigationService.Navigate(new Raport(comments,Data));
            }
        }
    }
    

