string kurs1 = "Yazılım geliştirici kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";


string[] kurslar = new string[] { "Yazılım geliştici kampı","programlamaya başlangıç için temel kurs","java"};



for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for bitti");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("sayfa sonu-footer");