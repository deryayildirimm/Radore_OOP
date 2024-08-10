// See https://aka.ms/new-console-template for more information
using Radore_OOP.Classes;
using Radore_OOP.HomeWork;

//Console.WriteLine("Hello, World!");

/*
//ClassIsmi nesneAdi = new ClassAdi();
Insan i = new Insan();
i.adi = "ibrahim";
i.soyadi = "gökyar";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = true;
i.uyu(i.adi,i.soyadi);


//Araba
Araba a = new Araba();
a.marka = "bmw";
a.model = "x5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.Git(a.marka,a.model);

Anne an = new Anne();
an.adi = "fahriye";
an.soyadi = "gökyar";
an.yas = 60;
an.cinsiyet = false;
an.ekranaYaz(an.adi, an.soyadi);
an.oku(an.adi);
an.yaz(an.adi);

Baba b = new Baba();
b.adi = "Kasım";
b.soyadi = "Gökyar";
b.ekranaYaz(b.adi, b.soyadi);
b.oku(b.adi);
b.dinle(b.adi);


Cocuk c = new Cocuk();
c.ekranaYaz("ibrahim", "gökyar");


AkilliCocuk ak = new AkilliCocuk();
ak.adSoyadSifatYaz("Hakan", "Yılmaz", "Akıllıdır");
ak.oku("Hakan");
ak.dinle("Hakan");
ak.yaz("Hakan");


UsluCocuk us = new UsluCocuk();
us.adi = "Mehmet";
us.soyadi = "Yıldız";
us.sifat = "Usludur";
us.adSoyadSifatYaz(us.adi, us.soyadi, us.sifat);
us.dinle(us.adi);
us.yaz(us.adi);


Matematik m = new Matematik();
int gelenDeger = m.topla(5, 5);
Console.WriteLine("Toplam : " + gelenDeger);
*/


Console.WriteLine("Sorunu çözmek için bir arayüz (interface) kullanarak loglama işlemini soyutladık");
Console.WriteLine("Böylece Logger sınıfını değiştirmeden yeni log tipleri ekleyebiliriz.");
Console.WriteLine("*********Kodlar HomeWork klasöründe bulunmakta***********");


ILog xmlLog = new XmlLog();
Logger logger = new Logger(xmlLog);
logger.LogKaydet("303 nolu hata kodu oluştu");

ILog dbLog = new DbLog();
Logger dbLogger = new Logger(dbLog);
dbLogger.LogKaydet("404 nolu hata kodu oluştu");

ILog jsonLog = new JsonLog();
Logger jsonLogger = new Logger(jsonLog);
jsonLogger.LogKaydet("500 nolu hata kodu oluştu");