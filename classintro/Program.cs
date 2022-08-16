Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Ebru";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "C++";
kurs2.Egitmen = "Erdem";
kurs2.IzlenmeOrani = 89;

//Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen)
Kurs[] kurslar = new Kurs[] {kurs1,kurs2} ;

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
}

class Kurs
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }

    public int IzlenmeOrani { get; set; }



}