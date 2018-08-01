using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audyt_innowacyjności
{
    public class Survey
    {
        public int Id { get; set; }
        public string NazwaPrzedsiebiorstwa { get; set; }
        public int IloscZmian { get; set; }
        public int NumerRegon { get; set; }
        public int NumerKRS { get; set; }
        public string Miasto { get; set; }
        //2///////////////////////////////////////////////////////////////////////

        public int WiekPrzedsiebiorstwa { get; set; }

        ///3//////////////////////////////////////////////////////////////////////

        public int IloscUmowOPrace { get; set; }
        public int IloscUmowCywilnoPrawnych { get; set; }
        public int IloscPracownikowSezonowych { get; set; }
        public string ZmianyWStrukturze { get; set; } //-Zmiany w strukturze i ilości zatrudnionych: - varchar50
        public string PoziomWyksztalcenia { get; set; }
        public int StazPracy { get; set; }
        public int WiekZatrudnienia { get; set; }

        ////4/////////////////////////////////////////////////////////////////////

        public int Obroty { get; set; }
        public int Zysk { get; set; }
        public int AktywaNiematerialne { get; set; }
        public int AktywaMaterialne { get; set; }
        public int AktywaPrawne { get; set; }
        public string ModelBiznesowy { get; set; }

        /////5////////////////////////////////////////////////////////////////////

        public string ZasiegDzialanosci { get; set; }


        //////6///////////////////////////////////////////////////////////////////

        public string ObszaryDzialanosci { get; set; }

        ///////7//////////////////////////////////////////////////////////////////

        public int SzczebleHierarchiPionowej { get; set; }
        public bool KoordynacjaPracy { get; set; }
        public string KoordynacjaPracyKomentarz { get; set; }
        public bool PracaZespolowa { get; set; }
        public bool KomunikacjaWewnetrzna { get; set; }
        public bool WsparcieInnowacji { get; set; }
        public int Innowacyjnosc { get; set; }
        public string ZarzadzanieRelacjami { get; set; }
        public int ZwiazkiFirmy { get; set; }
        public int StosunkiZAgencjami { get; set; }
        public int RelacjeIOB { get; set; }
        public int StosunkiZInstytucjami { get; set; }
        public string RelacjeZInstytucjami { get; set; }

        ////////8/////////////////////////////////////////////////////////////////

        public int ProcesoweLiczba { get; set; }
        public string ProcesoweKomentarz { get; set; }
        public int ProduktoweLiczba { get; set; }
        public string ProduktoweKomentarz { get; set; }
        public int OrgnizacyjneLiczba { get; set; }
        public string OrgnizacyjneKomentarz { get; set; }
        public int MarketingoweLiczba { get; set; }
        public string MarketingoweKomentarz { get; set; }


        /////////9////////////////////////////////////////////////////////////////

        public string BarieryWewnetrzne { get; set; }
        public string BarieryZewnetrzne { get; set; }

        //////////10///////////////////////////////////////////////////////////////

        public string MocneStrony { get; set; }
        public string SlabeStrony { get; set; }
        public string Szanse { get; set; }
        public string Zagrozenia { get; set; }

        ////////////11/////////////////////////////////////////////////////////////

        public bool Pracownicy { get; set; }
        public string PracownicyKomentarz { get; set; }
        public bool Konkurenci { get; set; }
        public string KonkurenciKomentarz { get; set; }
        public bool Klienci { get; set; }
        public string KlienciKomentarz { get; set; }
        public bool FirmyDoradcze { get; set; }
        public string FirmyDoradczeKomentarz { get; set; }
        public bool Uczelnie { get; set; }
        public string UczelnieKomentarz { get; set; }
        public bool Placowki { get; set; }
        public string PlacowkiKomentarz { get; set; }
        public bool Inne { get; set; }
        public string InneKomentarz { get; set; }

        //////////////12///////////////////////////////////////////////////////////

        //public Enum PraceBadawcze { get; set; }
        public string PraceBadawczeKomentarz { get; set; }

        ////////////////13/////////////////////////////////////////////////////////

        public bool KoloLubOrganizacja { get; set; }
        public string KoloLubOrganizacjaKomentarz { get; set; }

        //////////////////14///////////////////////////////////////////////////////

        public bool CertyfikatJakosci { get; set; }
        public string CertyfikatJakosciKomentarz { get; set; }

        /////15////////////////////////////////////////////////////////////////////

        public bool Badania { get; set; }
        public string BadaniaKomentarz { get; set; }
        public string CzasTrwaniaBadan { get; set; }
        public bool BadaniaNaRozwoj { get; set; }
        public string BadaniaNaRozwojKomentarz { get; set; }

        ///16/////////////////////////////////////////////////////////////////////

        //public Enum DziałaniaInnowacyjne { get; set; }
        

        //////17///////////////////////////////////////////////////////////////

        //public Enum NajwiecejKorzysci { get; set; }
        public string InneNazwa { get; set; }

        ///////18//////////////////////////////////////////////////////////////

        public bool PomiarStopniaInnowacyjnosci { get; set; }

        ////////19/////////////////////////////////////////////////////////////

        public bool NowechProdukty { get; set; }
        public int LiczbaNowychProduktow { get; set; }
        public bool WielkoscSprzedazy { get; set; }
        public int ProcentowaWielkoscSprzedazy { get; set; }
        public bool SprzedazInne { get; set; }
        public int WartoscSprzedazy { get; set; }
        public bool Zyski { get; set; }
        public int WartoscZyskow { get; set; }
        public bool NowePomysly { get; set; }
        public int LiczbaNowychPomyslow { get; set; }
        public bool NieudaneProjekty { get; set; }
        public int LiczbaNieudanychProjektow { get; set; }
        public bool CzyObliczanyCzas { get; set; }
        public int Czas { get; set; }
        public bool ZgloszeniaPatentowe { get; set; }
        public int LiczbaZgloszenPatentowych { get; set; }
        public bool PlanowaneProjekty { get; set; }
        public int LiczbaPlanowanychProjektow { get; set; }
        public bool OdrzuconeProjekty { get; set; }
        public int LiczbaOdrzuconychProjektow { get; set; }
        public bool PracownicyZNowymiPomyslami { get; set; }
        public int LiczbaPracownikowZNowymiPomyslami { get; set; }
        public bool NowePomyslySrednia { get; set; }
        public int LiczbaNowychPomyslowSrednia { get; set; }
        public bool CzasNaInnowacyjnosc { get; set; }
        public int IleCzasuNaInnowacyjnosc { get; set; }
        public bool InneWskazniki { get; set; }
        public int WartoscInnych { get; set; }

        //////20///////////////////////////////////////////////////////////////

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
        public int Wartosc1 { get; set; }
        public int Wartosc2 { get; set; }
        public int Wartosc3 { get; set; }
        public int Wartosc4 { get; set; }
        public int Wartosc5 { get; set; }
        public int Wartosc6 { get; set; }
        public int Wartosc7 { get; set; }
        public int Wartosc8 { get; set; }
        public int Wartosc9 { get; set; }
        public int Wartosc10 { get; set; }


        ///////21//////////////////////////////////////////////////////////////

        public string OdbiorcaUslug { get; set; }
        public string RelacjeFirmy { get; set; }
        public string UzytkownikKoncowy { get; set; }
        public string PotrzebyProduktow { get; set; }
        public string PowodyWyboruProduktow { get; set; }

        ///////22//////////////////////////////////////////////////////////////

        public string RynekUslug { get; set; }
        public string PerspektywaRozwoju { get; set; }

        ///////23//////////////////////////////////////////////////////////////

        public string StrategiaRozwoju { get; set; }
        public bool IstnienieStrategi { get; set; }
        public string Strategia { get; set; }

        ////////24/////////////////////////////////////////////////////////////

        public string Ceny { get; set; }
        public string UstalanieCen { get; set; }
        public int Marza { get; set; }
        public int ZyskownoscBranzy { get; set; }
        public int ZyskownoscFirmy { get; set; }

        //////////25///////////////////////////////////////////////////////////

        public string PrzewagaKonkurencyjna { get; set; }

        ////////////26/////////////////////////////////////////////////////////

        public string Konkurent { get; set; }
        public string OferantSybtytuty { get; set; }
        public string PotrzebySybtytutow { get; set; }

        ///////////27//////////////////////////////////////////////////////////

        public string RoznicaProduktow { get; set; }
    }
}
