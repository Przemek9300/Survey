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
                NumerRegon = model.NumerRegon,
                //2
                WiekPrzedsiebiorstwa = model.WiekPrzedsiebiorstwa,
                //3
                IloscUmowOPrace = model.IloscUmowOPrace,
                IloscUmowCywilnoPrawnych = model.IloscUmowCywilnoPrawnych,
                IloscPracownikowSezonowych = model.IloscPracownikowSezonowych,
                ZmianyWStrukturze = model.ZmianyWStrukturze,
       PoziomWyksztalcenia = model.PoziomWyksztalcenia,
        StazPracy = model.StazPracy,
        WiekZatrudnienia = model.WiekZatrudnienia,

        ////4/////////////////////////////////////////////////////////////////////

                Obroty = model.Obroty,
         Zysk = model.Zysk,
         AktywaNiematerialne = model.AktywaNiematerialne,
         AktywaMaterialne = model.AktywaMaterialne,
         AktywaPrawne = model.AktywaPrawne,
         ModelBiznesowy = model.ModelBiznesowy,

        /////5////////////////////////////////////////////////////////////////////

                ZasiegDzialanosci = model.ZasiegDzialanosci,


        //////6///////////////////////////////////////////////////////////////////

                ObszaryDzialanosci = model.ObszaryDzialanosci,

        ///////7//////////////////////////////////////////////////////////////////

                SzczebleHierarchiPionowej = model.SzczebleHierarchiPionowej,
        KoordynacjaPracy = model.KoordynacjaPracy,
         KoordynacjaPracyKomentarz = model.KoordynacjaPracyKomentarz,
         PracaZespolowa = model.PracaZespolowa,
         KomunikacjaWewnetrzna = model.KomunikacjaWewnetrzna,
         WsparcieInnowacji = model.WsparcieInnowacji,
         Innowacyjnosc = model.Innowacyjnosc,
         ZarzadzanieRelacjami = model.ZarzadzanieRelacjami,
         ZwiazkiFirmy = model.ZwiazkiFirmy,
         StosunkiZAgencjami = model.StosunkiZAgencjami,
         RelacjeIOB = model.RelacjeIOB,
         StosunkiZInstytucjami = model.StosunkiZInstytucjami,
         RelacjeZInstytucjami = model.RelacjeZInstytucjami,

        ////////8/////////////////////////////////////////////////////////////////

                ProcesoweLiczba = model.ProcesoweLiczba,
         ProcesoweKomentarz = model.ProcesoweKomentarz,
         ProduktoweLiczba = model.ProduktoweLiczba,
         ProduktoweKomentarz = model.ProduktoweKomentarz,
         OrgnizacyjneLiczba = model.OrgnizacyjneLiczba,
         OrgnizacyjneKomentarz = model.OrgnizacyjneKomentarz,
         MarketingoweLiczba = model.MarketingoweLiczba,
         MarketingoweKomentarz = model.MarketingoweKomentarz,


        /////////9////////////////////////////////////////////////////////////////

                BarieryWewnetrzne = model.BarieryWewnetrzne,
         BarieryZewnetrzne = model.BarieryZewnetrzne,

        //////////10///////////////////////////////////////////////////////////////

                MocneStrony = model.MocneStrony,
         SlabeStrony = model.SlabeStrony,
         Szanse = model.Szanse,
         Zagrozenia = model.Zagrozenia,

        ////////////11/////////////////////////////////////////////////////////////

                Pracownicy = model.Pracownicy,
         PracownicyKomentarz = model.PracownicyKomentarz,
         Konkurenci = model.Konkurenci,
         KonkurenciKomentarz = model.KonkurencjiKomentarz,
         Klienci = model.Klienci,
         KlienciKomentarz = model.KlienciKomentarz,
         FirmyDoradcze = model.FirmyDoradcze,
         FirmyDoradczeKomentarz = model.FirmyDoradczeKomentarz,
         Uczelnie = model.Uczelnie,
         UczelnieKomentarz = model.UczelnieKomentarz,
         Placowki = model.Placowki,
         PlacowkiKomentarz = model.PlacowkiKomentarz,
         Inne = model.Inne,
         InneKomentarz = model.InneKomentarz,

        //////////////12///////////////////////////////////////////////////////////

                // PraceBadawcze= model.PraceBadawcze,
                PraceBadawczeKomentarz = model.PraceBadawczeKomentarz,

        ////////////////13/////////////////////////////////////////////////////////

                KoloLubOrganizacja = model.KoloLubOrganizacja,
         KoloLubOrganizacjaKomentarz = model.KoloLubOrganizacjaKomentarz,
        //////////////////14///////////////////////////////////////////////////////

         CertyfikatJakosci = model.CertyfikatJakosci,
         CertyfikatJakosciKomentarz = model.CertyfikatJakosciKomentarz,

        /////15////////////////////////////////////////////////////////////////////

                Badania = model.Badania,
         BadaniaKomentarz = model.BadaniaKomentarz,
        CzasTrwaniaBadan = model.CzasTrwaniaBadan,
         BadaniaNaRozwoj = model.BadaniaNaRozwoj,
         BadaniaNaRozwojKomentarz = model.BadaniaNaRozwojKomentarz,

        ///16/////////////////////////////////////////////////////////////////////

                //DziałaniaInnowacyjne= model.


                //////17///////////////////////////////////////////////////////////////

                //NajwiecejKorzysci = model.
                InneNazwa = model.InneNazwa,

        ///////18//////////////////////////////////////////////////////////////

                PomiarStopniaInnowacyjnosci = model.PomiarStopniaInnowacyjnosci,

        ////////19/////////////////////////////////////////////////////////////

                NowechProdukty = model.NowechProdukty,
         LiczbaNowychProduktow = model.LiczbaNowychProduktow,
         WielkoscSprzedazy = model.WielkoscSprzedazy,
        ProcentowaWielkoscSprzedazy = model.ProcentowaWielkoscSprzedazy,
         SprzedazInne = model.SprzedazInne,
         WartoscSprzedazy = model.WartoscSprzedazy,
         Zyski = model.Zyski,
         WartoscZyskow = model.WartoscZyskow,
         NowePomysly = model.NowePomysly,
         LiczbaNowychPomyslow = model.LiczbaNowychPomyslow,
         NieudaneProjekty = model.NieudaneProjekty,
       LiczbaNieudanychProjektow = model.LiczbaNieudanychProjektow,
         CzyObliczanyCzas = model.CzyObliczanyCzas,
         Czas = model.Czas,
         ZgloszeniaPatentowe = model.ZgloszeniaPatentowe,
         LiczbaZgloszenPatentowych = model.LiczbaZgloszenPatentowych,
        PlanowaneProjekty = model.PlanowaneProjekty,
         LiczbaPlanowanychProjektow = model.LiczbaPlanowanychProjektow,
        OdrzuconeProjekty = model.OdrzuconeProjekty,
        LiczbaOdrzuconychProjektow = model.LiczbaOdrzuconychProjektow,
        PracownicyZNowymiPomyslami = model.PracownicyZNowymiPomyslami,
        LiczbaPracownikowZNowymiPomyslami = model.LiczbaPracownikowZNowymiPomyslami,
        NowePomyslySrednia = model.NowePomyslySrednia,
        LiczbaNowychPomyslowSrednia = model.LiczbaNowychPomyslowSrednia,
        CzasNaInnowacyjnosc = model.CzasNaInnowacyjnosc,
        IleCzasuNaInnowacyjnosc = model.IleCzasuNaInnowacyjnosc,
        InneWskazniki = model.InneWskazniki,
         WartoscInnych = model.WartoscInnych,

        //////20///////////////////////////////////////////////////////////////

                WyrobFirmy1 = model.WyrobFirmy1,
        WyrobFirmy2 = model.WyrobFirmy2,
         WyrobFirmy3 = model.WyrobFirmy3,
         WyrobFirmy4 = model.WyrobFirmy4,
         WyrobFirmy5 = model.WyrobFirmy5,
         WyrobFirmy6 = model.WyrobFirmy6,
         WyrobFirmy7 = model.WyrobFirmy7,
        WyrobFirmy8 = model.WyrobFirmy8,
       WyrobFirmy9 = model.WyrobFirmy9,
         WyrobFirmy10 = model.WyrobFirmy10,
         Wartosc1 = model.Wartosc1,
         Wartosc2 = model.Wartosc2,
         Wartosc3 = model.Wartosc3,
         Wartosc4 = model.Wartosc4,
        Wartosc5 = model.Wartosc5,
         Wartosc6 = model.Wartosc6,
         Wartosc7 = model.Wartosc7,
         Wartosc8 = model.Wartosc8,
         Wartosc9 = model.Wartosc9,
       Wartosc10 = model.Wartosc10,


        ///////21//////////////////////////////////////////////////////////////

                OdbiorcaUslug = model.OdbiorcaUslug,
         RelacjeFirmy = model.RelacjeFirmy,
         UzytkownikKoncowy = model.UzytkownikKoncowy,
         PotrzebyProduktow = model.PotrzebyProduktow,
        PowodyWyboruProduktow = model.PowodyWyboruProduktow,

        ///////22//////////////////////////////////////////////////////////////

                RynekUslug = model.RynekUslug,
         PerspektywaRozwoju = model.PerspektywaRozwoju,

        ///////23//////////////////////////////////////////////////////////////

                StrategiaRozwoju = model.StrategiaRozwoju,
        IstnienieStrategi = model.IstnienieStrategi,
       Strategia = model.Strategia,

        ////////24/////////////////////////////////////////////////////////////

                Ceny = model.Ceny,
         UstalanieCen = model.UstalanieCen,
         Marza = model.Marza,
         ZyskownoscBranzy = model.ZyskownoscBranzy,
        ZyskownoscFirmy = model.ZyskownoscFirmy,

        //////////25///////////////////////////////////////////////////////////

                PrzewagaKonkurencyjna = model.PrzewagaKonkurencyjna,

        ////////////26/////////////////////////////////////////////////////////

                Konkurent = model.Konkurent,
         OferantSybtytuty = model.OferantSybtytuty,
        PotrzebySybtytutow = model.PotrzebySybtytutow,

        ///////////27//////////////////////////////////////////////////////////

                RoznicaProduktow = model.RoznicaProduktow
            };
        }
    }
}
