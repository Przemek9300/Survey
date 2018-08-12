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

        public int Obroty
        {
            get { return obroty; }
            set
            {
                obroty = value;

                RaisePropertyChanged(nameof(Obroty));
                Validator.ValidateAsync(nameof(Obroty));

                {

                }

            }
        }
        public int Zysk
        {
            get { return zysk; }
            set
            {
                zysk = value;

                RaisePropertyChanged(nameof(Zysk));
                Validator.ValidateAsync(nameof(Zysk));

                {

                }

            }
        }
        public int AktywaNiematerialne
        {
            get { return aktywaNiematerialne; }
            set
            {
                aktywaNiematerialne = value;

                RaisePropertyChanged(nameof(AktywaNiematerialne));
                Validator.ValidateAsync(nameof(AktywaNiematerialne));

                {

                }

            }
        }
        public int AktywaMaterialne
        {
            get { return aktywaMaterialne; }
            set
            {
                aktywaMaterialne = value;

                RaisePropertyChanged(nameof(AktywaMaterialne));
                Validator.ValidateAsync(nameof(AktywaMaterialne));

                {

                }

            }
        }
        public int AktywaPrawne
        {
            get { return aktywaPrawne; }
            set
            {
                aktywaPrawne = value;

                RaisePropertyChanged(nameof(AktywaPrawne));
                Validator.ValidateAsync(nameof(AktywaPrawne));

                {

                }

            }
        }

        /////4////////////////////////////////////////////////////////////////////

        public string ZasiegDzialalnosci
        {
            get { return zasiegDzialanosci; }
            set
            {
                zasiegDzialanosci = value;

                RaisePropertyChanged(nameof(ZasiegDzialalnosci));
                Validator.ValidateAsync(nameof(ZasiegDzialalnosci));

                {

                }

            }
        }
        public int SzczebleHierarchiPionowej
        {
            get { return szczebleHierarchiPionowej; }
            set
            {
                szczebleHierarchiPionowej = value;

                RaisePropertyChanged(nameof(SzczebleHierarchiPionowej));
                Validator.ValidateAsync(nameof(SzczebleHierarchiPionowej));

                {

                }

            }
        }

        ///////5//////////////////////////////////////////////////////////////////

        public bool KoordynacjaPracy
        {
            get { return koordynacjaPracy; }
            set
            {
                koordynacjaPracy = value;

                RaisePropertyChanged(nameof(KoordynacjaPracy));
                Validator.ValidateAsync(nameof(KoordynacjaPracy));

                {

                }

            }
        }
        public string KoordynacjaPracyKomentarz
        {
            get { return koordynacjaPracyKomentarz; }
            set
            {
                koordynacjaPracyKomentarz = value;

                RaisePropertyChanged(nameof(KoordynacjaPracyKomentarz));
                Validator.ValidateAsync(nameof(KoordynacjaPracyKomentarz));

                {

                }

            }
        }
        public bool PracaZespolowa
        {
            get { return pracaZespolowa; }
            set
            {
                pracaZespolowa = value;

                RaisePropertyChanged(nameof(PracaZespolowa));
                Validator.ValidateAsync(nameof(PracaZespolowa));

                {

                }

            }
        }
        public bool WsparcieInnowacji
        {
            get { return wsparcieInnowacji; }
            set
            {
                wsparcieInnowacji = value;

                RaisePropertyChanged(nameof(WsparcieInnowacji));
                Validator.ValidateAsync(nameof(WsparcieInnowacji));

                {

                }

            }
        }
        public int Innowacyjnosc
        {
            get { return innowacyjnosc; }
            set
            {
                innowacyjnosc = value;

                RaisePropertyChanged(nameof(Innowacyjnosc));
                Validator.ValidateAsync(nameof(Innowacyjnosc));

                {

                }

            }
        }

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

        public string BarieryWewnetrzne
        {
            get { return barieryWewnetrzne; }
            set
            {
                barieryWewnetrzne = value;

                RaisePropertyChanged(nameof(BarieryWewnetrzne));
                Validator.ValidateAsync(nameof(BarieryWewnetrzne));

                {

                }

            }
        }
        public string BarieryZewnetrzne
        {
            get { return barieryZewnetrzne; }
            set
            {
                barieryZewnetrzne = value;

                RaisePropertyChanged(nameof(BarieryZewnetrzne));
                Validator.ValidateAsync(nameof(BarieryZewnetrzne));

                {

                }

            }
        }

        //////////////10///////////////////////////////////////////////////////////

        public string MocneStrony
        {
            get { return mocneStrony; }
            set
            {
                mocneStrony = value;

                RaisePropertyChanged(nameof(MocneStrony));
                Validator.ValidateAsync(nameof(MocneStrony));

                {

                }

            }
        }
        public string SlabeStrony
        {
            get { return slabeStrony; }
            set
            {
                slabeStrony = value;

                RaisePropertyChanged(nameof(SlabeStrony));
                Validator.ValidateAsync(nameof(SlabeStrony));

                {

                }

            }
        }
        public string Szanse
        {
            get { return szanse; }
            set
            {
                szanse = value;

                RaisePropertyChanged(nameof(Szanse));
                Validator.ValidateAsync(nameof(Szanse));

                {

                }

            }
        }
        public string Zagrozenia
        {
            get { return zagrozenia; }
            set
            {
                zagrozenia = value;

                RaisePropertyChanged(nameof(Zagrozenia));
                Validator.ValidateAsync(nameof(Zagrozenia));

                {

                }

            }
        }

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

        public string RynekUsług
        {
            get { return rynekUsług; }
            set
            {
                rynekUsług = value;

                RaisePropertyChanged(nameof(RynekUsług));
                Validator.ValidateAsync(nameof(RynekUsług));

                {

                }

            }
        }
        public PerpektywaRozwoju PerpektywaRozwoju { get; set; }
        public string StrategiaRozwoju
        {
            get { return strategiaRozwoju; }
            set
            {
                strategiaRozwoju = value;

                RaisePropertyChanged(nameof(StrategiaRozwoju));
                Validator.ValidateAsync(nameof(StrategiaRozwoju));

                {

                }

            }
        }
        public string CenyWStosunkuDoKonkurencji
        {
            get { return cenyWStosunkuDoKonkurencji; }
            set
            {
                cenyWStosunkuDoKonkurencji = value;

                RaisePropertyChanged(nameof(CenyWStosunkuDoKonkurencji));
                Validator.ValidateAsync(nameof(CenyWStosunkuDoKonkurencji));

                {

                }

            }
        }
        public string PrzewagaKonkurencyjna
        {
            get { return przewagaKonkurencyjna; }
            set
            {
                przewagaKonkurencyjna = value;

                RaisePropertyChanged(nameof(PrzewagaKonkurencyjna));
                Validator.ValidateAsync(nameof(PrzewagaKonkurencyjna));

                {

                }

            }
        }
        public string KonkurentISubstytuty
        {
            get { return konkurentISubstytuty; }
            set
            {
                konkurentISubstytuty = value;

                RaisePropertyChanged(nameof(KonkurentISubstytuty));
                Validator.ValidateAsync(nameof(KonkurentISubstytuty));

                {

                }

            }
        }
        public string RozniceProduktow
        {
            get { return rozniceProduktow; }
            set
            {
                rozniceProduktow = value;

                RaisePropertyChanged(nameof(RozniceProduktow));
                Validator.ValidateAsync(nameof(RozniceProduktow));

                {

                }

            }
        }


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

        /*public string RoznicaProduktow
        {
            get { return roznicaProduktow; }
            set
            {
                roznicaProduktow = value;

                RaisePropertyChanged(nameof(RoznicaProduktow));
                Validator.ValidateAsync(nameof(RoznicaProduktow));

                {

                }

            }
        }*/

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

            Validator.AddRequiredRule(() => IloscPracownikow, "Ilość pracowników jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(IloscPracownikow >= 0, "Wiek przedsiebiostwa musi być nieujemny"));
            Validator.AddRequiredRule(() => PoziomWyksztalcenia, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRequiredRule(() => StazPracy, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(StazPracy >= 0, "Wiek przedsiebiostwa musi być nieujemny"));
            Validator.AddRequiredRule(() => WiekPrzedsiebiorstwa, "Nazwa przedesiebiorstwa jest wymagana");
            Validator.AddRule(() => RuleResult.Assert(WiekPrzedsiebiorstwa >= 0, "Wiek przedsiebiostwa musi być nieujemny"));

            Validator.AddRequiredRule(() => ZasiegDzialalnosci, "Zasięg działalności jest wymagane");
            //Validator.AddRequiredRule(() => KoordynacjaPracyKomentarz, "Komentarz jest wymagany");
            //Validator.AddRequiredRule(() => ProcesoweKomentarz, "Procesowy komenatrz jest wymagany");
            //Validator.AddRequiredRule(() => ProduktoweKomentarz, "Komenatrz do produktu jest wymagany");
            //Validator.AddRequiredRule(() => OrgnizacyjneKomentarz, "Komenatrz do Organizacji jest wymagany");
            //Validator.AddRequiredRule(() => MarketingoweKomentarz, "Komenatrz do Marketingu jest wymagany");

            Validator.AddRequiredRule(() => BarieryWewnetrzne, "Bariery wewnętrzne są wymagane");
            Validator.AddRequiredRule(() => BarieryZewnetrzne, "Bariery zewnetrzne są wymagane");



            Validator.AddRequiredRule(() => MocneStrony, "Mocne strony są wymagane");
            Validator.AddRequiredRule(() => SlabeStrony, "Słabe strony są wymagane");
            Validator.AddRequiredRule(() => Szanse, "Szanse są wymagane");
            Validator.AddRequiredRule(() => Zag, "Zagrożenia są wymagane");


















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

