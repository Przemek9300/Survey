using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audyt_innowacyjności.ViewModel
{
     public class SurveyViewModel: ValidatableModel
    {
        private string nazwaPrzedsiebiorstwa;
        [Required]
        [StringLength(20)]
        public string NazwaPrzedsiebiorstwa
        {
            get { return nazwaPrzedsiebiorstwa; }
            set { nazwaPrzedsiebiorstwa = value; RaisePropertyChanged("NazwaPrzedsiebiorstwa"); }
        }
        public int IloscZmian { get; set; }
        public int NumerRegon { get; set; }
        public int NumerKRS { get; set; }
        public string Miasto { get; set; }


    }
}
