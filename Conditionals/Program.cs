class Program
{
    public static void Main()
    {
        #region If

        //int x = 50;

        //if (x > 30)
        //{
        //    Console.WriteLine("Sayı 30'dan büyüktür");
        //}

        #endregion

        #region If - else

        //int x = 50;

        //if (x > 60)
        //{
        //    Console.WriteLine("Sayı 60'dan büyüktür.");
        //}
        //else
        //{
        //    Console.WriteLine("Sayı 60'dan küçüktür.");
        //}

        #endregion

        #region If - else if - else

        //int x = 10;

        //if (x == 0)
        //{
        //    Console.WriteLine("Sayı 0'dır.");
        //}
        //else if (x == 10)
        //{
        //    Console.WriteLine("Sayı 10'dur.");
        //}
        //else
        //{
        //    Console.WriteLine("Sayı 0 ya da 10 değildir.");
        //}

        #endregion

        #region Süslü parantez kullanmadan yazım

        //int number = 10;

        //if (number != 0)
        //    Console.WriteLine("Sayı 0 değildir.");
        //else
        //    Console.WriteLine("Sayı 0'dır.");

        #endregion

        #region Nested If

        //int age = 18;
        //bool hasLıcensed = true;

        //if (age >= 18)
        //{
        //    if (hasLıcensed == true)
        //        Console.WriteLine("Araç kullanabilirsiniz.");
        //    else
        //        Console.WriteLine("Araç kullanmak için ehliyet gereklidir.");
        //}
        //else
        //{
        //    Console.WriteLine("Araç kullanmak için gereklı yaş sınırı 18'dir.");
        //}

        #endregion

        #region Mantıksal operatörlerle If 

        //int number = 200;

        //if (number >= 0 && number <= 100)
        //    Console.WriteLine("Sayı 0 ile 100 arasındadır.");
        //else if (number > 100 && number <= 300)
        //    Console.WriteLine("Sayı 101 ile 300 arasındadır.");
        //else 
        //    Console.WriteLine("Sayı ya 0'dan küçük ya da 300'den büyüktür.");

        #endregion

        #region If ile karar verme

        //Console.Write("Bir sayı giriniz: ");
        //int number=Convert.ToInt32(Console.ReadLine());

        //if (number % 2 == 0)
        //    Console.WriteLine("Girilen sayı çift sayıdır.");
        //else
        //    Console.WriteLine("Girilen sayı tek sayıdır.");

        #endregion

        #region Switch

        //int x = 0;

        //switch (x)
        //{
        //    case 10:
        //        Console.WriteLine("Sayı 10'dur.");
        //        break;
        //    case 0:
        //        Console.WriteLine("Sayı 0'dır.");
        //        break;
        //    default:
        //        Console.WriteLine("Sayı 10 ya da 0 değildir.");
        //        break;
        //}

        #endregion

        #region Ternary Operatör

        int y = 50;

        Console.WriteLine(y > 40 ? "Sayı 40'dan büyüktür." : "Sayı 40'dan küçüktür.");

        #endregion

        Console.ReadLine();
    }
}