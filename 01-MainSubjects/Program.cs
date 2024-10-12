// using: Kullanacağımız kodlara ait kütüphaneleri tutmaktadır.
// Bu şekilde kütüphanelerin kullanılmasının sebebi;
/*
   Programlamada her bir kod bir kütüphaneye yani using değerine aittir.
   Yazılım dünyası, neye ihtiyacın varsa onu buraya using ile dahil et veya ederim diyor.
   Ben sana bir başlık altında sunmuyorum diyor çünkü bir başlık altında bütün kütüphaneleri sunsaydı sistem çok yorulacaktı.
   Bu da bize Yazılım Dünyasının : Böl - Parçala - Yönet mantığına uyduğunu gösterir.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Projenin ismidir, yani kapsama alanıdır.
namespace _01_MainSubjects
{
	// Program derlenince çalışacak ana class'tır.
	internal class Program
	{
		// Program sınıfı derlenince çalışacak ana metottur.
		static void Main(string[] args)
		{   // Yazdığımız kodları bölüm bölüm ayırabilmek için #region kullanırız.
			#region Yazdırma Komutları
			// Program derlenince konsol ekranına: Hello World ! yazılmasını sağlamaktadır.
			// Not: Bir yapının metot olduğunu anlamak için, intellisense ekranında sol ikonu mor bir küp ise o bir metottur.
			// Metot içerisinde çıktıda gösterilecek içerik yazılır.
			// İçerik eğer alfabetik bir metin ise çift tırnak içerisinde yazılır.

			// Not: C# programlama dilinde, derleyicinin kodları yorumlayabilmesi için yani kodun orada bittiğini anlayabilmesi için noktalı virgül eklenmek zorunludur.

			// Console.Write("Merhaba Dünya!");

			// WriteLine ise içerisindeki içeriği konsola yazar sonrasında bir satır boşluk bırakır.
			// Console.WriteLine("Selam");

			// Enter tuşuna basana kadar ekranı bekletecek olan koddur.
			// Console.Read();

			/*
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
			Console.WriteLine("***** Yemek Kategorileri *****");
            */
			// Bölümün tamamlandığı yere #endregion koymamız gerekmektedir.
			#endregion

			#region String Değişkenler
			// Çeşitli türe sahip verileri bellekte tutabilmek ve sonradan işlem yapabilmek için değişkenleri kullanırız.
			// Değişkenleri kullanmamızın bir diğer sebebi de bir veriyi birden fazla yerde kullanmak ve kullandığımız veriyi tek bir
			// noktadan değiştirebilmektir.

			// string: Alfabetik yani metinsel türde veri alabilen bir değişken türüdür.
			// string variableName;
			// Değişken tanımlama adımları: degiskenturu degiskenAdi;
			string name;
			// Tanımladığımız değişkene ilgili değişken türüne göre bir değer ataması gerçekleştiriyoruz;
			// "=" programlamada atama operatörü olarak kullanılır.
			name = "Gökay Baz";
            // Değişkene tanımlandıktan ve içerisine değer atandıktan sonra ilgili değişken değeri ile beraber bellekte kendine bir alan ayırır.
            // Oluşturduğumuz değişkeni konsola yazdıralım;

			// Bundan önce konsol ekranına yazdırırken çift tırnak içerisine veri girerek yazdırıyorduk, ama artık değişken kullandığımız için-
			// değişkenimizin ismini yazıyoruz. İlgili değişken ismi bize yazdıracağımız değeri temsil ettiği için bu şekilde kullanıyoruz.
			// Böylece her bu değeri kullanacığımız yerde değişken adını kullanırsak, sonradan değişkenin değerini tanımladğımız yerde değiştirerek
			// bütün bu değişkeni kullandığımız alanlarda ilgili değerin güncellenmesini sağlarız, böylece daha merkezi bir yönetim sağlanır.
            //Console.WriteLine(name);

			// C# da değişken tanımlarken, değişken ismini isimlendirme kuralı olan: camelCase ile oluştururuz.
			// Değişken ismi olabildiğince açık ve yalın olmalıdır.
			string customerName;
			string customerSurname;
			string customerPhone;
			// Tek satırda aynı türden birden fazla değişken tanımlaması yapabilmekteyiz.
			string customerEmail, customerDistrict, customerCity;

			customerName = "Hakkı";
			customerSurname = "Baz";
			customerPhone = "+905512331163";
			customerEmail = "hbaz456@gmail.com";
			customerDistrict = "Kozan";
			customerCity = "Adana";

            //Console.WriteLine("**** Rezervasyon Kartları ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------");
			// String Toplama: Birden fazla string değeri "+" yani toplama operatörü ile toplayıp yan yana yazılmasını sağlayabiliriz.
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			// "\n" string ifadelerde satır atlama için kullanılır.
            //Console.WriteLine("İletişim: " + customerPhone + "\n" + "Email: " + customerEmail);
            //Console.WriteLine("Adres: " + customerCity + "/" + customerCity);
			//Console.WriteLine("------------------------------------------------------");

			//Console.WriteLine("");

			// Programlamada hiyerarşik bir atama sıralandırması vardır, yukarıdan başlar satır satır okuyarak son satıra kadar okuma işlemlerini yapar.
			// Console.WriteLine("Eski Değer: " + customerName);
			// Biz burada önceden tanımladığımız değeri değiştiriyoruz.
			// customerName = "Benan";
			// Burada konsol ekranına yeni değeri yazar.
			// Console.WriteLine("Yeni Değer: " + customerName);
			customerName = "Benan";
			customerSurname = "Baz";
			customerPhone = "+905445085479";
			customerEmail = "benan456@gmail.com";
			customerDistrict = "Çukurova";
			customerCity = "Adana";

			//Console.WriteLine("------------------------------------------------------");
			// String Toplama: Birden fazla string değeri "+" yani toplama operatörü ile toplayıp yan yana yazılmasını sağlayabiliriz.
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			// "\n" string ifadelerde satır atlama için kullanılır.
			//Console.WriteLine("İletişim: " + customerPhone + "\n" + "Email: " + customerEmail);
			//Console.WriteLine("Adres: " + customerCity + "/" + customerCity);
			//Console.WriteLine("------------------------------------------------------");
			#endregion

			#region Integer Değişkenler
			// int: Tam sayı türündeki değişkenlerdir.
			//int age = 20;
			//Console.WriteLine("Kullanıcının yaşı: " + age);
			int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            Console.WriteLine("-> Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-> Kola: " + cokePrice + " TL");
            Console.WriteLine("-> Su: " + waterPrice + " TL");
            Console.WriteLine("-> Kızartma Çeşitleri: " + friesPrice + " TL");
            Console.WriteLine("-> Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-> Limonata: " + lemonadePrice + " TL");

			Console.WriteLine();


			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			int totalPrice = 0;

			hamburgerCount = 3;
			cokeCount = 3;
			waterCount = 3;
			friesCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;

			totalPrice = ((hamburgerCount * hamburgerPrice) + (cokeCount * cokePrice) + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice));
            
			Console.WriteLine();
			Console.WriteLine("---- Adisyon ----");
            Console.WriteLine();
			Console.WriteLine("-> Hamburger: " + hamburgerPrice + " TL * " +  hamburgerCount + " Adet" + " -> " + (hamburgerCount * hamburgerPrice) + " TL");
            Console.WriteLine("-> Kola: " + cokePrice + " TL * " +  cokeCount + " Adet" + " -> " + (cokeCount * cokePrice) + " TL");
            Console.WriteLine("-> Su: " + waterPrice + " TL * " +  waterCount + " Adet" + " -> " + (waterCount * waterPrice) + " TL");
            Console.WriteLine("-> Kızartma: " + friesPrice + " TL * " +  friesCount + " Adet" + " -> " + (friesCount * friesPrice) + " TL");
            Console.WriteLine();
			Console.WriteLine("----> Toplam Ödenecek Tutar: " + totalPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("******************************");

			// Ders Tamamlandı!
			#endregion

		}
	}
}
