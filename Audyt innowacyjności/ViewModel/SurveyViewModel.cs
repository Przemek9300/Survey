using System;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MvvmValidation;
using System.Windows.Input;

namespace Audyt_innowacyjności.ViewModel
{
     public class SurveyViewModel: ValidatableViewModelBase
    {
        private string validationErrorsString;
        private bool? isValid;
        public ICommand ValidateCommand { get; private set; }
        public SurveyViewModel()
        {
            ValidateCommand = new RelayCommand(Validate);
            Validator = new ValidationHelper();
            ConfigureValidationRules();
            Validator.ResultChanged += OnValidationResultChanged;
        }
        protected ValidationHelper Validator { get; private set; }
        private string nazwaPrzedsiebiorstwa;

        public string NazwaPrzedsiebiorstwa
        {
            get { return nazwaPrzedsiebiorstwa; }
            set
            {
                nazwaPrzedsiebiorstwa = value;
            
                RaisePropertyChanged(nameof(NazwaPrzedsiebiorstwa));
                Validator.ValidateAsync(nameof(NazwaPrzedsiebiorstwa));

                {

                   
                }

            }
        }
          public string ValidationErrorsString
        {
            get { return validationErrorsString; }
            private set
            {
                validationErrorsString = value;
                RaisePropertyChanged(nameof(ValidationErrorsString));
            }
        }
        public int Id { get; set; }
        public string Branza { get; set; }
        public int NumerRegon { get; set; }
        public int NumerKRS { get; set; }
        public string Miasto { get; set; }
        public int WiekPrzedsiebiorstwa { get; set; }

        ///2//////////////////////////////////////////////////////////////////////

        public int IloscPracownikow { get; set; }
        public string PoziomWyksztalcenia { get; set; }
        public int StazPracy { get; set; }
        public int WiekZatrudnienia { get; set; }

        ////3/////////////////////////////////////////////////////////////////////

        public int Obroty { get; set; }
        public int Zysk { get; set; }
        public int AktywaNiematerialne { get; set; }
        public int AktywaMaterialne { get; set; }
        public int AktywaPrawne { get; set; }

        /////4////////////////////////////////////////////////////////////////////

        public string ZasiegDzialanosci { get; set; }
        public int SzczebleHierarchiPionowej { get; set; }

        ///////5//////////////////////////////////////////////////////////////////

        public bool KoordynacjaPracy { get; set; }
        public string KoordynacjaPracyKomentarz { get; set; }
        public bool PracaZespolowa { get; set; }
        public bool WsparcieInnowacji { get; set; }
        public int Innowacyjnosc { get; set; }

        public int ZwiazkiFirmy { get; set; }
        public int StosunkiZAgencjami { get; set; }
        public int StosunkiZInstytucjami { get; set; }

        ////////6/////////////////////////////////////////////////////////////////

        public int ProcesoweLiczba { get; set; }
        public string ProcesoweKomentarz { get; set; }
        public int ProduktoweLiczba { get; set; }
        public string ProduktoweKomentarz { get; set; }
        public int OrgnizacyjneLiczba { get; set; }
        public string OrgnizacyjneKomentarz { get; set; }
        public int MarketingoweLiczba { get; set; }
        public string MarketingoweKomentarz { get; set; }


        /////////7////////////////////////////////////////////////////////////////

        public int WprowadzoneInnowacje { get; set; }
        public int NowePomysły { get; set; }
        public int ZyskiNoweWyroby { get; set; }
        public int ZyskiInnowacjeInne { get; set; }
        public int DlugoscCykli { get; set; }
        public int WydatkiInnowacyjnosc { get; set; }
        public int SredniaIloscPomyslow { get; set; }
        public int SklonnoscDoRyzyka { get; set; }


        ////////8////////////////////////////////////////////////////////////////

        public bool Pracownicy { get; set; }
        public bool Konkurenci { get; set; }
        public bool Klienci { get; set; }
        public bool FirmyDoradcze { get; set; }
        public bool Uczelnie { get; set; }
        public bool Placowki { get; set; }
        public bool Inne { get; set; }
        public string InneKomentarz { get; set; }

        public bool PoszerzenieOferty { get; set; }
        public bool UlatwienieDzialanProdukcyjnych { get; set; }
        public bool PoprawaJakosciUslug { get; set; }
        public bool WzrostPrestizu { get; set; }
        public bool NoweKontakty { get; set; }
        public bool ZmniejszenieKosztow { get; set; }
        public bool OdpowiedziDoKlientow { get; set; }

        public bool PomiarStopniaInnowacyjnosci { get; set; }
        public string PomiarStopniaInnowacyjnosciKomentarz { get; set; }
        //////////////9///////////////////////////////////////////////////////////

        public string BarieryWewnetrzne { get; set; }
        public string BarieryZewnetrzne { get; set; }

        //////////////10///////////////////////////////////////////////////////////

        public string MocneStrony { get; set; }
        public string SlabeStrony { get; set; }
        public string Szanse { get; set; }
        public string Zagrozenia { get; set; }

        //////////////11///////////////////////////////////////////////////////////

        //public Enum PraceBadawcze { get; set; }
        public string PraceBadawczeKomentarz { get; set; }
        public bool KoloLubOrganizacja { get; set; }
        public string KoloLubOrganizacjaKomentarz { get; set; }
        public bool CertyfikatJakosci { get; set; }
        public string CertyfikatJakosciKomentarz { get; set; }
        public bool PomiarStopniaSwiadczonychUslug { get; set; }
        public string PomiarStopniaSwiadczonychUslugKomentarz { get; set; }

        ///12//////////////////////////////////////////////////////////////////////


        public string WyrobFirmy1 { get; set; }
        public string WyrobFirmy2 { get; set; }
        public string WyrobFirmy3 { get; set; }
        public string WyrobFirmy4 { get; set; }
        public string WyrobFirmy5 { get; set; }
        public string WyrobFirmy6 { get; set; }
        public string WyrobFirmy7 { get; set; }
        public string WyrobFirmy8 { get; set; }
        public string WyrobFirmy9 { get; set; }
        public string WyrobFirmy10 { get; set; }

        public string RynekUsług { get; set; }
        //public Enum PerpektywaRozwoju { get; set; } Do wyboru: Wschodzący, schyłkowy, stabilny, niestabilny
        public string StrategiaRozwoju { get; set; }
        public string CenyWStosunkuDoKonkurencji { get; set; }
        public string PrzewagaKonkurencyjna { get; set; }
        public string KonkurentISubstytuty { get; set; }
        public string RozniceProduktow { get; set; }


        ///13/////////////////////

        public bool RozbudowaOferty { get; set; }
        public bool LepszaPromocja { get; set; }
        public bool ModernizacjaZaplecza { get; set; }
        public bool NoweOprogramowanie { get; set; }
        public bool InneDzialania { get; set; }
        public string InneDzialaniaKomentarz { get; set; }

        public bool? IsValid
        {
            get { return isValid; }
            private set
            {
                isValid = value;
                RaisePropertyChanged(nameof(IsValid));
            }
        }

        public string RoznicaProduktow { get; set; }

        private void ConfigureValidationRules()
        {
            Validator.AddRequiredRule(() => NazwaPrzedsiebiorstwa, "User Name is required");

        }
      

        private async void Validate()
        {
            await ValidateAsync();
        }

        private async Task ValidateAsync()
        {
            var result = await Validator.ValidateAllAsync();

            UpdateValidationSummary(result);
        }

        private void OnValidationResultChanged(object sender, ValidationResultChangedEventArgs e)
        {
            if (!IsValid.GetValueOrDefault(true))
            {
                MvvmValidation.ValidationResult validationResult = Validator.GetResult();

                UpdateValidationSummary(validationResult);
            }
        }

        private void UpdateValidationSummary(ValidationResult validationResult)
        {
            IsValid = validationResult.IsValid;
            ValidationErrorsString = validationResult.ToString();
        }
    }


}

