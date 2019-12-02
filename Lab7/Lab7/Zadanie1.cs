using System;
using System.Collections.Generic;

namespace Lab7 {
  public class Zadanie1 {
    public void Run() {

      List<IStatData> IStatDataList = new List<IStatData>();
      List<ICepikData> ICepikDataList = new List<ICepikData>();
      List<IPoliceData> IPoliceDataList = new List<IPoliceData>();

      Auto A1 = new Auto();
      A1.Typ = "Sedan";
      A1.Marka = "Audi";
      A1.Rok = 2009;
      A1.Wlasciciel_ImieNazwisko = "Jan Kowalski";
      A1.Wlasciciel_LiczbaPunktowKarnych = 12;

      IStatDataList.Add(A1);
      ICepikDataList.Add(A1);
      IPoliceDataList.Add(A1);

      foreach (IStatData a in IStatDataList) {
        Console.WriteLine("Typ: {0}, Marka: {1}, Rocznik: {2}", a.Typ, a.Marka, a.Rok );
      }

      foreach (ICepikData a in ICepikDataList) {
        Console.WriteLine("Typ: {0}, Marka: {1}, Rocznik: {2}, Wlasciciel: {3}", a.Typ, a.Marka, a.Rok, a.Wlasciciel_ImieNazwisko);
      }

      foreach (IPoliceData a in IPoliceDataList) {
        Console.WriteLine("Typ: {0}, Marka: {1}, Rocznik: {2}, Wlasciciel: {3}, Liczba pkt karnych: {4}", a.Typ, a.Marka, a.Rok, a.Wlasciciel_ImieNazwisko, a.Wlasciciel_LiczbaPunktowKarnych);
      }

    }
  }

  public interface IStatData {

    string Typ { get; set; }
    string Marka { get; set; }
    int Pojemnosc { get; set; }
    string VIN { get; set; }
    string NrRej { get; set; }
    int Rok { get; set; }
    string Kolor { get; set; }
    string NrPolisy { get; set; }

  }
  public interface ICepikData {

    string Typ { get; set; }
    string Marka { get; set; }
    int Pojemnosc { get; set; }
    string VIN { get; set; }
    string NrRej { get; set; }
    int Rok { get; set; }
    string Kolor { get; set; }
    string NrPolisy { get; set; }

    string Wlasciciel_ImieNazwisko { get; set; }
    string Wlasciciel_AdresZamieszkania { get; set; }
    long Wlasciciel_PESEL { get; set; }
    long Wlasciciel_NrPrawaJazdy { get; set; }
    DateTime Wlasciciel_DataUzyskaniaPrawaJazdy { get; set; }
    int Wlasciciel_RokZakupu { get; set; }

  }


  public interface IPoliceData {

    string Typ { get; set; }
    string Marka { get; set; }
    int Pojemnosc { get; set; }
    string VIN { get; set; }
    string NrRej { get; set; }
    int Rok { get; set; }
    string Kolor { get; set; }
    string NrPolisy { get; set; }

    string Wlasciciel_ImieNazwisko { get; set; }
    string Wlasciciel_AdresZamieszkania { get; set; }
    long Wlasciciel_PESEL { get; set; }
    long Wlasciciel_NrPrawaJazdy { get; set; }
    DateTime Wlasciciel_DataUzyskaniaPrawaJazdy { get; set; }
    int Wlasciciel_RokZakupu { get; set; }
    int Wlasciciel_LiczbaPunktowKarnych { get; set; }

  }

  public class Auto : IStatData, ICepikData, IPoliceData {

    public string Typ { get; set; }
    public string Marka { get; set; }
    public int Pojemnosc { get; set; }
    public string VIN { get; set; }
    public string NrRej { get; set; }
    public int Rok { get; set; }
    public string Kolor { get; set; }
    public string NrPolisy { get; set; }

    public string Wlasciciel_ImieNazwisko { get; set; }
    public string Wlasciciel_AdresZamieszkania { get; set; }
    public long Wlasciciel_PESEL { get; set; }
    public long Wlasciciel_NrPrawaJazdy { get; set; }
    public DateTime Wlasciciel_DataUzyskaniaPrawaJazdy { get; set; }
    public int Wlasciciel_RokZakupu { get; set; }
    public int Wlasciciel_LiczbaPunktowKarnych { get; set; }

    public Auto() { }

  }


}
