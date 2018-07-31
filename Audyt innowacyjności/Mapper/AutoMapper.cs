using Audyt_innowacyjności.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audyt_innowacyjności.Mapper
{
    public static class AutoMapper
    {
        public static Survey Map(SurveyViewModel model)
        {
            return new Survey
            {
                IloscZmian = model.IloscZmian,
                Miasto = model.Miasto,
                NazwaPrzedsiebiorstwa = model.NazwaPrzedsiebiorstwa,
                NumerKRS = model.NumerKRS,
                NumerRegon = model.NumerRegon
            };
        }
    }
}
