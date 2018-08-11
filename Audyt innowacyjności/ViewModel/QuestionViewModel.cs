using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audyt_innowacyjności.ViewModel
{
    public static class QuestAionViewModel
    {
        public static Dictionary<int, string> questions = new Dictionary<int, string>() { { 1, " Informacje ogólne "},
            { 2, " Informacje o pracownikach "},
            { 3, " Finanse przedsiębiorstwa "},
            { 4, " Dodatkowe dane o przedsiębiorstwie "},
            { 5, " Dodatkowe dane o przedsiębiorstwie II "},
            { 6, " Wprowadzane innowacje w przedsiębiorstwie na przełomie ostatnich 3 lat "},
            { 7, " Wskaźniki innowacji "}, { 8, " Źródła innowacji i cele innowacji w firmie "},
            { 9, " Bariery wpływające na wolniejszy rozwój innowacyjności "},
            { 10, " SWOT przedsiębiorstwa "},
            { 11, " Kultura przedsiębiorstwa "},
            { 12, " Oferta firmy i cechy rynku "},
            { 13, " Jakie działania w Pana(i) firmie przyniosłyby najwięcej korzyści dla firmy "}, }; }
}
