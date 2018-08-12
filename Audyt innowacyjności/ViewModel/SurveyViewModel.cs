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






        private string nazwaPrzedsiebiorstwa;
        private string branza;
        private int numerRegon;
        private string numerKRS;
        private string miasto;
        private int wiekPrzedsiebiorstwa;
        private int iloscPracownikow;
        private string poziomWyksztalcenia;
        private int stazPracy;
        private int wiekZatrudnienia;
        private int obroty;
        private int zysk;
        private int aktywaNiematerialne;
        private int aktywaMaterialne;
        private int aktywaPrawne;
        private string zasiegDzialanosci;
        private int szczebleHierarchiPionowej;
        private bool koordynacjaPracy;
        private string koordynacjaPracyKomentarz;
        private bool pracaZespolowa;
        private bool wsparcieInnowacji;
        private int innowacyjnosc;
        private int zwiazkiFirmy;
        private int stosunkiZApgencjami;
        private int stosunkiZInstytucjami;
        private int procesoweLiczba;
        private string procesoweKomentarz;
        private int produktoweLiczba;
        private string produktoweKomentarz;
        private int orgnizacyjneLiczba;
        private string orgnizacyjneKomentarz;
        private int marketingoweLiczba;
        private string marketingoweKomentarz;
        private int wprowadzoneInnowacje;
        private int nowePomysły;
        private int zyskiNoweWyroby;
        private int zyskiInnowacjeInne;
        private int dlugoscCykli;
        private int wydatkiInnowacyjnosc;
        private int sredniaIloscPomyslow;
        private int sklonnoscDoRyzyka;
        private bool pracownicy;
        private bool konkurenci;
        private bool klienci;
        private bool firmyDoradcze;
        private bool uczelnie;
        private bool placowki;
        private bool inne;
        private string inneKomentarz;
        private bool poszerzenieOferty;
        private bool ulatwienieDzialanProdukcyjnych;
        private bool poprawaJakosciUslug;
        private bool wzrostPrestizu;
        private bool noweKontakty;
        private bool zmniejszenieKosztow;
        private bool odpowiedziDoKlientow;
        private bool pomiarStopniaInnowacyjnosci;
        private string pomiarStopniaInnowacyjnosciKomentarz;
        private string barieryWewnetrzne;
        private string barieryZewnetrzne;
        private string mocneStrony;
        private string slabeStrony;
        private string szanse;
        private string zagrozenia;
        private PraceBadawcze praceBadawcze;
        private string praceBadawczeKomentarz;
        private bool koloLubOrganizacja;
        private string koloLubOrganizacjaKomentarz;
        private bool certyfikatJakosci;
        private string certyfikatJakosciKomentarz;
        private bool pomiarStopniaSwiadczonychUslug;
        private string pomiarStopniaSwiadczonychUslugKomentarz;
        private string wyrobFirmy1;
        private string wyrobFirmy2;
        private string wyrobFirmy3;
        private string wyrobFirmy4;
        private string wyrobFirmy5;
        private string wyrobFirmy6;
        private string wyrobFirmy7;
        private string wyrobFirmy8;
        private string wyrobFirmy9;
        private string wyrobFirmy10;
        private string rynekUsług;
        private PerpektywaRozwoju perpektywaRozwoju;
        private string strategiaRozwoju;
        private string cenyWStosunkuDoKonkurencji;
        private string przewagaKonkurencyjna;
        private string konkurentISubstytuty;
        private string rozniceProduktow;
        private bool rozbudowaOferty;
        private bool lepszaPromocja;
        private bool modernizacjaZaplecza;
        private bool noweOprogramowanie;
        private bool inneDzialania;
        private string inneDzialaniaKomentarz;


        public ICommand ValidateCommand { get; private set; }
        public SurveyViewModel()
        {
            ValidateCommand = new RelayCommand(Validate);
            Validator = new ValidationHelper();
            ConfigureValidationRules();
            Validator.ResultChanged += OnValidationResultChanged;
        }
        protected ValidationHelper Validator { get; private set; }




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
        public string Branza
        {
            get { return branza; }
            set
            {
                branza = value;

                RaisePropertyChanged(nameof(Branza));
                Validator.ValidateAsync(nameof(Branza));

                {


                }

            }
        }

        public int Id { get; set; }
        

        public int NumerRegon
        {
            get { return numerRegon; }
            set
            {
                numerRegon = value;

                RaisePropertyChanged(nameof(NumerRegon));
                Validator.ValidateAsync(nameof(NumerRegon));

                {


                }

            }
        }
        public string NumerKRS
        {
            get { return numerKRS; }
            set
            {
                numerKRS = value;

                RaisePropertyChanged(nameof(NumerKRS));
                Validator.ValidateAsync(nameof(NumerKRS));

                {


                }

            }
        }
        public string Miasto
        {
            get { return miasto; }
            set
            {
                miasto = value;

                RaisePropertyChanged(nameof(Miasto));
                Validator.ValidateAsync(nameof(Miasto));

                {


                }

            }
        }
        public int WiekPrzedsiebiorstwa
        {
            get { return wiekPrzedsiebiorstwa; }
            set
            {
                wiekPrzedsiebiorstwa = value;

                RaisePropertyChanged(nameof(WiekPrzedsiebiorstwa));
                Validator.ValidateAsync(nameof(WiekPrzedsiebiorstwa));

                {


                }

            }
        }

        ///2//////////////////////////////////////////////////////////////////////


        public int IloscPracownikow
        {
            get { return iloscPracownikow; }
            set
            {
                iloscPracownikow = value;

                RaisePropertyChanged(nameof(IloscPracownikow));
                Validator.ValidateAsync(nameof(IloscPracownikow));

                {

                }

            }
        }
        public string PoziomWyksztalcenia
        {
            get { return poziomWyksztalcenia; }
            set
            {
                poziomWyksztalcenia = value;

                RaisePropertyChanged(nameof(PoziomWyksztalcenia));
                Validator.ValidateAsync(nameof(PoziomWyksztalcenia));

                {

                }

            }
        }
        public int StazPracy
        {
            get { return stazPracy; }
            set
            {
                stazPracy = value;

                RaisePropertyChanged(nameof(StazPracy));
                Validator.ValidateAsync(nameof(StazPracy));

                {

                }

            }
        }
        public int WiekZatrudnienia
        {
            get { return wiekZatrudnienia; }
            set
            {
                wiekZatrudnienia = value;

                RaisePropertyChanged(nameof(WiekZatrudnienia));
                Validator.ValidateAsync(nameof(WiekZatrudnienia));

                {

                }

            }
        }

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

        public PraceBadawcze PraceBadawcze { get; set; }
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
        public PerpektywaRozwoju PerpektywaRozwoju { get; set; }
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
            Validator.AddRequiredRule(() => NazwaPrzedsiebiorstwa, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRequiredRule(() => Branza, "Nazwa branży jest wymagana");
            Validator.AddRequiredRule(() => NumerRegon, "Numer Regon jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(NumerRegon.ToString().Length == 9, "Niepoprawny numer Regon"));
            Validator.AddRequiredRule(() => NumerKRS, "Numer KRS jest wymagana");
            Validator.AddRequiredRule(() => Miasto, "Miasto jest wymagana");
            Validator.AddRequiredRule(() => WiekPrzedsiebiorstwa, "Wiek przedsiebiostwa jest wymagany");
            Validator.AddRule(() => RuleResult.Assert(WiekPrzedsiebiorstwa>=0, "Wiek przedsiebiostwa musi być nieujemny"));

            Validator.AddRequiredRule(() => IloscPracownikow, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(IloscPracownikow >= 0, "Wiek przedsiebiostwa musi być nieujemny"));
            Validator.AddRequiredRule(() => PoziomWyksztalcenia, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRequiredRule(() => StazPracy, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(StazPracy >= 0, "Wiek przedsiebiostwa musi być nieujemny"));
            Validator.AddRequiredRule(() => WiekPrzedsiebiorstwa, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(WiekPrzedsiebiorstwa >= 0, "Wiek przedsiebiostwa musi być nieujemny"));

            Validator.AddRequiredRule(() => ZasiegDzialanosci, "Zasięg działalności jest wymagane");
            //Validator.AddRequiredRule(() => KoordynacjaPracyKomentarz, "Komentarz jest wymagany");
            //Validator.AddRequiredRule(() => ProcesoweKomentarz, "Procesowy komenatrz jest wymagany");
            //Validator.AddRequiredRule(() => ProduktoweKomentarz, "Komenatrz do produktu jest wymagany");
            //Validator.AddRequiredRule(() => OrgnizacyjneKomentarz, "Komenatrz do Organizacji jest wymagany");
            //Validator.AddRequiredRule(() => MarketingoweKomentarz, "Komenatrz do Marketingu jest wymagany");

            Validator.AddRequiredRule(() => BarieryWewnetrzne, "Bariery wewnętrzne są wymagane");
            Validator.AddRequiredRule(() => BarieryZewnetrzne, "Bariery zewnetrzne są wymagane");



            Validator.AddRequiredRule(() => MocneStrony, "Mocne strony są wymagane");
            Validator.AddRequiredRule(() => SlabeStrony, "Słabe strony są wymagane");
            Validator.AddRequiredRule(() => MocneStrony, "Szanse są wymagane");
            Validator.AddRequiredRule(() => MocneStrony, "Zagrożenia są wymagane");


















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

