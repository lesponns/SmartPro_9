using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MATH. FUNCTION

            /*
            * Math.Pow(x,y): Bu metot sayesinde vereceğimiz iki parametrenin ilk verilen değeri taban, 
              ikinci verilen değeri üst olarak kabul ederek üs alma işlemi gerçekleştirir.

            * Math.Sqrt(x): Karekök hesaplama konusunda uzun bir şekilde algoritma yazmaya gerek
              duymadan vereceğimiz parametrenin karekökünü hesaplar.

            * Math.Abs(x): Matematiksel işlemleri gerçekleştirirken mutlak değer alma işlemini kafadan
              çok rahat bir şekilde gerçekleştirerek işlemlerimizi gerçekleştiririz. Bunu bizim 
              yerimize programlarımızda Abs metodu gerçekleştirmektedir.

            * Math.Floor(x): Kullanırken vereceğimiz ondalıklı bir sayıyı tamsayı cinsinden bir 
              altındaki değere yuvarlama işlemi gerçekleştirir. Örnek olarak 5.7 değerini 5’e 
              dönüştürür.

            * Math.Ceiling(x): Aldığı parametre içerisindeki ondalıklı değeri, bir üst değere yuvarlar.
              Bu değerin ondalıklı değeri isterse 1 olsun isterse 9 olsun yine de her zaman bir üste
              yuvarlar. Örnek: 5.1 değerini 6’ya yuvarlar.

            * Math.Max(x,y): Alacağı parametreler arasında sorgulama işlemi gerçekleştirerek sorgulanan 
              değerlerden büyük değere sahip olanı geri döndürür.

            * Math.Min(x,y): Math.Max’de olduğu gibi aynı şekilde işlemleri gerçekleştirirken bu sefer 
              en küçük değeri geri döndürür.

            * Math.Sin():Trigonometri içerisinde bulunan sinüs değerinin hesaplanması için kullanılır. 
              Bu hesaplamayı verilen parametreyi radyan olarak kabul ederek gerçekleştirir.

            * Math.Asin():Sin metodunun tersine atanan parametreyi sinüs değerini alır ve bu değere 
              karşılık gelen açıyı radyan cinsinden bizlere gösterir.

            * Math.Cos(): Radyan cinsinden verilen parametredeki değeri bizlere kosinüs değeri olarak 
              döndürür.
            
            * Math.Acos(): Asin metodu gibi bir işlemin tersini gerçekleştireceğini başındaki A harfinden 
              anlayabiliriz. Parametre olarak atanacak kosinüs değeri alır ve radyan cinsinden bizlere 
              elde edilen değeri gösterir.

            * Math.Tan(): Yukarıdaki işlemlere benzer bir şekilde parametre olarak aldığı radyan cinsinden 
              değerin tanjant karşılığını bizlere gösterir.

            * Math.Atan(): Atanan parametredeki değeri alır ve bu değerin radyan cinsini bizlere gösterir.  

            * Math.PI: 3,14 olarak başlan pi değerinin ilk 15 basamağının çıktısını bizlere verir.

            * Math.E: Trigonometri ve Logaritma hesaplamalarında sıklıkla kullanılan E kavramının sabit 
              değerine ulaşmak istediğimiz zaman bu sabit değere ulaşmamıza yardımcı olur.

            */



            Console.WriteLine(Math.Pow(5,4));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-12));
            Console.WriteLine(Math.Floor(6.872));
            Console.WriteLine(Math.Ceiling(6.872));
            Console.WriteLine(Math.Max(48,35));
            Console.WriteLine(Math.Min(48,35));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Asin(-10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Acos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Atan(-10));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);

            


            Console.ReadKey();
            #endregion
            
        }
    }
}
