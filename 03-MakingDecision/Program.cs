using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Karar yapıları
			// Programlama yaparken bir koşula göre işlem yaptıracaksak karar yapılarını kullanmak zorundayız.
			// Bu yüzden programlamanın yapı taşıdır denebilir.

			#region If Else
			//Console.Write("Lütfen şifrenizi giriniz: ");
			//string userPassword = Console.ReadLine();

			//Burada kontrol edilecek değer kullanıcının şifresidir.

			// if: eğer demektir.
			// (buraya koşul yazılır)

			// eğer kullanıcı şifresi eşit ise gokayy123'e
			//if (userPassword == "gokay1123")
			//{
			//	kullanıcı sisteme giriş yapsın
			//	Console.WriteLine("Şifre doğru, sisteme girişiniz sağlanıyor...");
			//}
			//else: değil ise
			// koşul sağlanmıyorsa
			//else
			//{
			//	kullanıcı sisteme giriş yapamasın!
			//   Console.WriteLine("Şifre hatalı, lütfen kontrol ediniz!");
			//}

			// if else yapıları case sensivity'dir. (Yani büyük küçük harf duyarlıdır.)

			// if else yapılarında birden fazla koşul barındırılabilir;

			//string capital, country;

			//Console.Write("Başkentinizi giriniz: ");
			//capital = Console.ReadLine();

			//Console.Write("Ülkenizi giriniz: ");
			//country = Console.ReadLine();

			// '& -> Ve operatörü ile birden fazla koşulu tek bir if içerisinde barındırabiliriz'
			// Not: Ve operatörü kullandığımız için her iki koşulun da sağlanması gerekmektedir.
			//if (capital == "Ankara" & country == "Türkiye")
			//{
			//Console.WriteLine("Veriler Doğrulandı!");
			//}
			//else
			//{
			//Console.WriteLine("Hatalı Bilgi!");
			//}

			//Console.Write("Lütfen yaşınızı giriniz: ");
			//int age = int.Parse(Console.ReadLine());

			// if yaş büyükse veya eşit ise 18'e demiş olduk.
			//if(age >= 18)
			//{
			//Console.WriteLine("Reşit bir bireysiniz :)");
			//}else
			//{
			//Console.WriteLine("Reşit bir birey değilsiniz :(");
			//}

			//string city;
			//Console.Write("Lütfen şehrinizi giriniz: ");
			//city = Console.ReadLine();

			//"|"->Veya demektir if bloğunun çalışması için içerisine verilen koşullardan birisinin karşılanması yeterlidir.
			//if (city == "Adana" | city == "Mersine" | city == "Antalya")
			//{
			//	Console.WriteLine("Akdeniz bölgesi");
			//}
			//else
			//{
			//	Console.WriteLine("Bilinmiyor");
			//}

			//string userName;

			//Console.WriteLine("Kullanıcı adınızı giriniz: ");
			//userName = Console.ReadLine();

			//"!="->Eşit değil ise demektir
			//if (userName != "admin")
			//{
			//	Console.WriteLine("Kullanıcı adı yanlış!!!");
			//}
			//else
			//{
			//	Console.WriteLine("Kullanıcı adı doğru :)");
			//}
			#endregion

			#region If ElseIf
			//int exam1, exam2, exam3, result;

			//Console.Write("Birinci sınav notunuzu giriniz: ");
			//exam1 = int.Parse(Console.ReadLine());

			//Console.Write("İkinci sınav notunuzu giriniz: ");
			//exam2 = int.Parse(Console.ReadLine());

			//Console.Write("Üçüncü sınav notunuzu giriniz: ");
			//exam3 = int.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;

			//if (result < 50)
			//{
			//	Console.WriteLine("Maalesef sınıfta kaldınız...");
			//}
			//Değil ise eğer diyerek tek bir if bloğu kullanarak birden fazla birbirinden bağımsız koşullar verebiliriz.
			//else if (result >= 50 & result < 70)
			//{
			//	Console.WriteLine("Sınıfı sorumlu bir şekilde geçtiniz...");
			//}
			//else if (result >= 70 & result < 85)
			//{
			//	Console.WriteLine("Sınıfı güzel bir şekilde geçtiniz...");
			//}
			//else
			//{
			//	Console.WriteLine("Sınıfı mükemmel bir şekilde geçtiniz...");
			//}
			#endregion

			#region Mod Alma
			// Aritmetik işlemlerde iki sayının birbirine bölümünden kalanı almaya: Mod alma denmektedir.
			// Mod Operatörünün sembolü programlamada: "%" sembolüdür.

			//int number1, number2, result;

			//Console.Write("Birinci sayıyı giriniz: ");
			//number1 = int.Parse(Console.ReadLine());

			//Console.Write("İkinci sayıyı giriniz: ");
			//number2 = int.Parse(Console.ReadLine());

			//result = number1 % number2;

			//Console.WriteLine();
			//Console.WriteLine($"Birinci sayının ikinci sayıya bölümünden kalan: {result}");

			// Biz bu işlemi en çok bir sayını tek mi çift mi olduğunu anlamak için kullanıyoruz;
			//int number;
			//Console.Write("Bir sayı giriniz: ");
			//number = int.Parse(Console.ReadLine());

			//if (number % 2 == 0)
			//{
			//	Console.WriteLine("Girilen sayı çift bir sayıdır!");
			//}
			//else
			//{
			//	Console.WriteLine("Girilen sayı tek bir sayıdır!");
			//}
			#endregion

			#region Char Türü ile Karar Yapıları Örnek
			//char userTeam;

			//Console.Write("Takım harfinizi giriniz: ");
			//userTeam = char.Parse(Console.ReadLine());

			//if (userTeam == 'f' | userTeam == 'F')
			//{
			//	Console.WriteLine("Fenerbahçelisiniz...");
			//}
			//else if (userTeam == 'g' | userTeam == 'G')
			//{
			//	Console.WriteLine("Galatasaraylısınız...");
			//}
			//else if (userTeam == 'b' | userTeam == 'B')
			//{
			//	Console.WriteLine("Beşiktaşlısınız...");
			//}
			//else
			//{
			//	Console.WriteLine("Başka bir takımlısınız...");
			//}
			#endregion

			#region OrnekUygulama

			// Kullanıcıya yemek seçme ekranı sunalım,
			// Kategorilere göre yemekler listelensin

			//Console.WriteLine("****** Baz Restaurant ******");
			//Console.WriteLine();

			//Console.WriteLine("*** Menü ***");
			//Console.WriteLine("1 - Çorba Çeşitleri");
			//Console.WriteLine("2 - Izgara Çeşitleri");
			//Console.WriteLine("3 - Sulu Yemek Çeşitleri");
			//Console.WriteLine("4 - İçecek Çeşitleri");

			//Console.WriteLine("Lütfen Seçiminizi Yapınız (1,2,3,4): ");
			//int userSelectedNumber = int.Parse(Console.ReadLine());

			//if (userSelectedNumber == 1)
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("* Çorba Çeşitleri *");
			//	Console.WriteLine("- Mercimek Çorbası");
			//	Console.WriteLine("- Kelle Paça Çorbası");
			//	Console.WriteLine("- Yoğurtlu Çorba");
			//	Console.WriteLine("- Yayla Çorbası");
			//}
			//else if (userSelectedNumber == 2)
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("* Izgara Çeşitleri *");
			//	Console.WriteLine("- Kanat Izgara");
			//	Console.WriteLine("- Tavuk Izgara");
			//	Console.WriteLine("- Izgara Köfte");
			//	Console.WriteLine("- Izgara Pirzola");
			//}
			//else if (userSelectedNumber == 3)
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("* Sulu Yemek Çeşitleri *");
			//	Console.WriteLine("- Kuru Fasulye");
			//	Console.WriteLine("- Nohut Sote");
			//	Console.WriteLine("- Tavuk Haşlama");
			//	Console.WriteLine("- Et Haşlama");
			//}
			//else if (userSelectedNumber == 4)
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("* İçecek Çeşitleri *");
			//	Console.WriteLine("- Ayran");
			//	Console.WriteLine("- Şalgam");
			//	Console.WriteLine("- Kola");
			//	Console.WriteLine("- Limonata");
			//}
			#endregion

			#region Switch Case
			// Karar yapılarında birden fazla şart kontrolü olabilir.
			// Mesela klavyeden girilen sayıya göre yılın ilgili ayını veren bir kod sorusu düşünün, bu sorunun çözümünü en kolay ve performanslı şekilde switch - case ile çözebiliriz.

			// -> switch: kod bloğunun anahtar kısmı
			// -> case: anahtarın durumlarını tuttuğumuz alan
			// -> break: kullanılması zorunludur çünkü ilgili case'de istenilen şart sağlanıyorsa switch-case yapısını kesecektir, diğer case'leri kontrol etmeyecektir.
			// -> default: koşul durumu hiçbir case'de belirtilmemişse çalışacak alandır.

			//int monthIndex;

			//Console.Write("Lütfen yılın ay numarasını giriniz: ");
			//monthIndex = int.Parse(Console.ReadLine());

			//switch (monthIndex)
			//{
			//	case 1:
			//		Console.WriteLine("Ocak Ayı");
			//		break;
			//	case 2:
			//		Console.WriteLine("Şubat Ayı");
			//		break;
			//	case 3:
			//		Console.WriteLine("Mart Ayı");
			//		break;
			//	case 4:
			//		Console.WriteLine("Nisan Ayı");
			//		break;
			//	case 5:
			//		Console.WriteLine("Mayıs Ayı");
			//		break;
			//	case 6:
			//		Console.WriteLine("Haziran Ayı");
			//		break;
			//	case 7:
			//		Console.WriteLine("Temmuz Ayı");
			//		break;
			//	case 8:
			//		Console.WriteLine("Ağustos Ayı");
			//		break;
			//	case 9:
			//		Console.WriteLine("Eylül Ayı");
			//		break;
			//	case 10:
			//		Console.WriteLine("Ekim Ayı");
			//		break;
			//	case 11:
			//		Console.WriteLine("Kasım Ayı");
			//		break;
			//	case 12:
			//		Console.WriteLine("Aralık Ayı");
			//		break;
			//	default:
			//		Console.WriteLine("Girilen Ay Numarası Bilinmemektedir!!!");
			//		break;
			//}
			#endregion

			#region Switch Case Hesap Makinesi
			//int number1, number2, result;
			//char symbol;

			//Console.Write("Birinci sayıyı giriniz: ");
			//number1 = int.Parse(Console.ReadLine());

			//Console.Write("İkinci sayıyı giriniz: ");
			//number2 = int.Parse(Console.ReadLine());

			//Console.Write("Yaptırmak istediğiniz işlemi seçiniz (+,-,*,/,%): ");
			//symbol = char.Parse(Console.ReadLine());

			//Console.WriteLine();
			//switch (symbol)
			//{
			//	case '+':
			//		Console.WriteLine("+ Toplama İşlemi +");
			//		result = number1 + number2;
			//		Console.WriteLine($"İşlem sonucu: {result}");
			//		break;
			//	case '-':
			//		Console.WriteLine("- Çıkarma İşlemi -");
			//		result = number1 - number2;
			//		Console.WriteLine($"İşlem sonucu: {result}");
			//		break;
			//	case '*':
			//		Console.WriteLine("* Çarpma İşlemi *");
			//		result = number1 * number2;
			//		Console.WriteLine($"İşlem sonucu: {result}");
			//		break;
			//	case '/':
			//		Console.WriteLine("/ Bölme İşlemi /");
			//		result = number1 / number2;
			//		Console.WriteLine($"İşlem sonucu: {result}");
			//		break;
			//	case '%':
			//		Console.WriteLine("% Mod Alma İşlemi %");
			//		result = number1 % number2;
			//		Console.WriteLine($"İşlem sonucu: {result}");
			//		break;
			//}
			#endregion

			// Ders Tamamlandı!!!

		}
	}
}
