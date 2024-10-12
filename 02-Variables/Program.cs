using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			//Variables - Değişkenler

			// string ve int değişken türlerini görmüştük, şimdi diğer değişken türleri ile devam edelim;

			#region Double Değişkenler
			//double değişkenler
			///*
			//  Ondalıklı sayılar için kullanılır.
			//*/
			//double length = 1.67;
			//Not->Kod tarafında ondalıklı sayıyı nokta ile tanımlarken,
			//program tarafında virgül ile gözüktü. Buradan şu sonucu çıkarabiliriz;
			//Kod tarafında ondalıklı ifadeyi belirttiğimiz nokta sembolü, Konsol ekranında bize virgül olarak dönmektedir.
			//Console.WriteLine($"Kullanıcının boyu: {length}");

			//Pratik yapalım;
			// > Meyve ve Sebzeler kilogramı ile beraber oluşturulsun,
			// > Oluşturulan meyve ve sebzelere kilogram fiyatları belirlensin,
			// > Çıkan sonuç ekrana yazdırılsın.

			// 1 - Meyve ve Sebzeleri Oluşturalım;

			//string apple = "Kırmızı Elma";
			//string watermelon = "Karpuz";
			//string banana = "Muz";
			//string pear = "Armut";

			//string pumpkin = "Kabak";
			//string beans = "Fasulye";
			//string eggplant = "Patlıcan";
			//string pepper = "Biber";

			//2 - Oluşturduğumuz Meyve ve Sebzelerin Kilogramlarını Belirleyelim;

			//double appleWeight = 1.89;
			//double watermelonWeight = 8.79;
			//double bananaWeight = 2.89;
			//double pearWeight = 5.78;

			//double pumpkinWeight = 15.78;
			//double beansWeight = 6.42;
			//double eggplantWeight = 4.36;
			//double pepperWeight = 9.23;

			//3 - Kilogram Birimini Tanımlayalım;

			//string unit = "Kilogram";
			//string shortUnit = "Kg";

			//4 - Oluşturduğumuz Meyve Ve Sebzelerin Birim Başına Fiyatlarını Belirleyelim;

			//double applePricePerUnit = 5.50;
			//double watermelonPricePerUnit = 9.90;
			//double bananaPricePerUnit = 8.20;
			//double pearPricePerUnit = 2.36;

			//double pumpkinPricePerUnit = 2.10;
			//double beansPricePerUnit = 1.50;
			//double eggplantPricePerUnit = 1;
			//double pepperPricePerUnit = 0.50;

			//Para birimimizi belirleyelim;
			//string priceUnit = "TL";

			//5 - Oluşturduğumuz Meyve ve Sebzelerin Satın Alınan Kilogram ile Birim Fiyatını Çarparak Ödenmesi Gereken Ücreti Yazalım;

			//Console.WriteLine();
			//Console.WriteLine("****** BAZ MANAV ******");
			//Console.WriteLine();

			//Console.WriteLine("*** Ürünler ***");
			//Console.WriteLine("-----------------");
			//Console.WriteLine();
			//Console.WriteLine($"> {apple} {shortUnit} -> {applePricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {watermelon} {shortUnit} -> {watermelonPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {banana} {shortUnit} -> {bananaPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {pear} {shortUnit} -> {pearPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {pumpkin} {shortUnit} -> {pumpkinPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {beans} {shortUnit} -> {beansPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {eggplant} {shortUnit} -> {eggplantPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine($"> {pepper} {shortUnit} -> {pepperPricePerUnit}{priceUnit}");
			//Console.WriteLine();
			//Console.WriteLine("-------------------------------------");
			//Console.WriteLine();

			//Müşteri her üründen 1.5 kg alım yapsın
			//double customerShopWeight = 1.5;

			//Console.WriteLine("*** Adisyon ***");
			//Console.WriteLine("-----------------");
			//Console.WriteLine($"> {apple} {shortUnit} -> {applePricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {watermelon} {shortUnit} -> {watermelonPricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {banana} {shortUnit} -> {bananaPricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {pear} {shortUnit} -> {pearPricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {pumpkin} {shortUnit} -> {pumpkinPricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {beans} {shortUnit} -> {beansPricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {eggplant} {shortUnit} -> {eggplantPricePerUnit * customerShopWeight}{priceUnit}");
			//Console.WriteLine($"> {pepper} {shortUnit} -> {pepperPricePerUnit * customerShopWeight}{priceUnit}");

			//double totalPrice = ((applePricePerUnit * customerShopWeight) + (watermelonPricePerUnit * customerShopWeight) + (bananaPricePerUnit * customerShopWeight) + (pearPricePerUnit * customerShopWeight) + (pumpkinPricePerUnit * customerShopWeight) + (beansPricePerUnit * customerShopWeight) + (eggplantPricePerUnit * customerShopWeight) + (pepperPricePerUnit * customerShopWeight));
			//Console.WriteLine("-------------------------------------");
			//Console.WriteLine(); Console.WriteLine($"Toplam Ödenmesi Gereken: {totalPrice}");

			#endregion

			#region Char Değişkenler
			// Karakter değeri tutabilen değişken türüdür.
			// Tek tırnak içerisinde değer tutulmalıdır, aksi halde hata verecektir.
			char userChar = 'G';
			//Console.WriteLine($"Kullanıcı Karakteri: {userChar}");
			#endregion

			#region Klavyeden Veri Girişleri - String Türünde Veri Alma
			//Console.WriteLine("**** BAZ Hava Yolları Yolcu Bilgisi ****");
			//Console.WriteLine();

			//string customerName, customerSurname, customerDistrict, customerCity, customerAge, customerIdentityNumber;

			//Console.Write("Adınızı Giriniz: ");
			// Console.ReadLine() : Konsol satırını okumaya yaramaktadır.
			// Biz öncesinde konsol ekranını kapatmasın diye kullanıyorduk çünkü konsol ekranını okuduğu için konsolun kapanmasını engellemiş oluyor.
			// Konsoldan string veri alabilmek için ReadLine kullanıyoruz.
			// Aslında çalışma mantığı aynı metin giriş kutucukları gibidir içerisine veriyi girer ve bir değişkene atarız, ilgili değişken girilmiş veriyi tutar. Böylece dışarıdan kullanıcı programa veri girişi yapabilir.
			// WriteLine satıra yazıyor, ReadLine satırı okuyor.
			//customerName = Console.ReadLine();

			//Console.Write("Soyadınızı Giriniz: ");
			//customerSurname = Console.ReadLine();

			//Console.Write("İlçenizi Giriniz: ");
			//customerDistrict = Console.ReadLine();

			//Console.Write("İlinizi Giriniz: ");
			//customerCity = Console.ReadLine();

			//Console.Write("Yaşınızı Giriniz: ");
			//customerAge = Console.ReadLine();

			//Console.Write("TC Kimlik Numaranızı Giriniz: ");
			//customerIdentityNumber = Console.ReadLine();

			//Console.WriteLine("------------------------------------------");
			//Console.WriteLine($"Yolcu Adı: {customerName}");
			//Console.WriteLine($"Yolcu Soyadı: {customerSurname}");
			//Console.WriteLine($"Yolcu İlçesi: {customerDistrict}");
			//Console.WriteLine($"Yolcu İli: {customerCity}");
			//Console.WriteLine($"Yolcu Yaşı: {customerAge}");
			//Console.WriteLine($"Yolcu Kimlik Numarası: {customerIdentityNumber}");
			//Console.WriteLine("------------------------------------------");


			#endregion

			#region Klavyeden Veri Girişleri - Int Türünde Veri Alma ve Dönüşümler

			// C# programlama dili konsol ekranına girilen değerleri başlangıçta string olarak kabul etmektedir.
			// Eğer biz başka türde değer girip işlem yapacaksak tip dönüştürme işlemi yani tip dönüşümü yapmamız gerekmektedir.
			// Program aslında bana girilen değerin sayı olduğunu bildir demek istiyor.

			// string değeri en kolay biçimde int değere dönüştürmek için: int.Parse(donusturulecekDeger) kullanabiliriz.

			//int laptopPrice = 25000;
			//int desktopPrice = 30000;
			//int monitorPrice = 6500;
			//int mousePrice = 3000;
			//int keyboardPrice = 4000;

			//         Console.Write("Satın almak istediğiniz laptop miktarını giriniz: ");
			//int laptopCount = int.Parse(Console.ReadLine());

			//Console.Write("Satın almak istediğiniz masaüstü miktarını giriniz: ");
			//int desktopCount = int.Parse(Console.ReadLine());

			//Console.Write("Satın almak istediğiniz monitör miktarını giriniz: ");
			//int monitorCount = int.Parse(Console.ReadLine());

			//Console.Write("Satın almak istediğiniz fare miktarını giriniz: ");
			//int mouseCount = int.Parse(Console.ReadLine());

			//Console.Write("Satın almak istediğiniz klavye miktarını giriniz: ");
			//int keyboardCount = int.Parse(Console.ReadLine());

			//// Klavyeden girilen değeri int türüne parse et, dönüştür demiş olduk.

			//int totalPrice = (laptopCount * laptopPrice) + (desktopCount * desktopPrice) + (monitorCount * monitorPrice) + (mouseCount * mousePrice) + (keyboardCount * keyboardPrice);

			//         Console.WriteLine();

			//         Console.WriteLine($"Toplam ödemeniz gereken miktar: {totalPrice} TL");


			#endregion

			#region Klavyeden Veri Girişleri - Double Türünde Veri Alma ve Dönüşümler
			//double exam1, exam2, exam3, result;
			//Console.Write("Lütfen birinci sınav notunu giriniz: ");
			//int'da olduğu gibi double türünde de Parse metotunu kullanarak dönüşüm işlemlerini yapabilmekteyiz.
			//exam1 = double.Parse(Console.ReadLine());

			//Console.Write("Lütfen ikinci sınav notunu giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;

			//Console.WriteLine();

			//Console.WriteLine($"Ortalamanız: {result}");
			#endregion

			#region Klavyeden Veri Girişleri - Char Türünde Veri Alma ve Dönüşümleri
			//char gender;
			//Console.Write("Lütfen cinsiyet seçiniz: ");
			//gender = char.Parse(Console.ReadLine());

			//Console.WriteLine();

			//Console.WriteLine($"Seçilen Cinsiyet: {gender}");
			#endregion

			// Ders Tamamlandı!

			Console.ReadLine();

		}
	}
}
