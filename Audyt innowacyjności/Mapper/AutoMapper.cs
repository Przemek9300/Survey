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
                Id = model.Id,
                NazwaPrzedsiebiorstwa = model.NazwaPrzedsiebiorstwa,
                Branza = model.Branza,
                Miasto = model.Miasto,
                NumerKRS = model.NumerKRS,
                NumerRegon = model.NumerRegon,
                //2
                WiekPrzedsiebiorstwa = model.WiekPrzedsiebiorstwa,
                
       PoziomWyksztalcenia = model.PoziomWyksztalcenia,
        StazPracy = model.StazPracy,
        WiekZatrudnienia = model.WiekZatrudnienia,

        ////4/////////////////////////////////////////////////////////////////////

                Obroty = model.Obroty,
         Zysk = model.Zysk,
         AktywaNiematerialne = model.AktywaNiematerialne,
         AktywaMaterialne = model.AktywaMaterialne,
         AktywaPrawne = model.AktywaPrawne,

        /////5////////////////////////////////////////////////////////////////////

                ZasiegDzialanosci = model.ZasiegDzialanosci,


        //////6///////////////////////////////////////////////////////////////////


        ///////7//////////////////////////////////////////////////////////////////

                SzczebleHierarchiPionowej = model.SzczebleHierarchiPionowej,
        KoordynacjaPracy = model.KoordynacjaPracy,
         KoordynacjaPracyKomentarz = model.KoordynacjaPracyKomentarz,
         PracaZespolowa = model.PracaZespolowa,
         WsparcieInnowacji = model.WsparcieInnowacji,
         Innowacyjnosc = model.Innowacyjnosc,
         ZwiazkiFirmy = model.ZwiazkiFirmy,
         StosunkiZAgencjami = model.StosunkiZAgencjami,
         StosunkiZInstytucjami = model.StosunkiZInstytucjami,

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
         Konkurenci = model.Konkurenci,
         Klienci = model.Klienci,
         FirmyDoradcze = model.FirmyDoradcze,
         Uczelnie = model.Uczelnie,
         Placowki = model.Placowki,
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


                //DziałaniaInnowacyjne= model.


                

                //NajwiecejKorzysci = model.
           



                PomiarStopniaInnowacyjnosci = model.PomiarStopniaInnowacyjnosci,

   
        

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



        

                StrategiaRozwoju = model.StrategiaRozwoju,
       

            


                PrzewagaKonkurencyjna = model.PrzewagaKonkurencyjna,

            };
        }
    }
}
