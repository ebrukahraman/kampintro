//type safety=tip güvenliği
// do not repeat yourself = Kendini tekrarlama
string kategoriEtiketi = "Kategori";
Console.WriteLine(kategoriEtiketi);
int ogrenciSayisi = 32000;
double faizOranı = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.35;
double dolarBugun = 7.45;
if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarBugun>dolarDun)
{
    Console.WriteLine("Artış Butonu");

}
else
{
    Console.WriteLine("Eşittir Butonu");
}

if (sistemeGirisYapmisMi==true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");    
}

Console.WriteLine(ogrenciSayisi);
Console.WriteLine(faizOranı);

