
# C# Kontrol Yapıları ve Operatörler Örnekleri

Bu proje, C# dilinde temel kontrol yapıları ve operatörlerin kullanımını örneklerle gösteren bir konsol uygulamasıdır. İçerisinde `if`, `if-else`, `if-else if-else`, `nested if`, mantıksal operatörler, `switch` yapısı ve ternary operatör gibi temel konular yer almaktadır.

---

## İçindekiler

- [If Yapısı](#if-yapısı)
- [If - Else Yapısı](#if---else-yapısı)
- [If - Else If - Else Yapısı](#if---else-if---else-yapısı)
- [Süslü Parantez Kullanımı Olmadan If](#süslü-parantez-kullanımı-olmadan-if)
- [Nested If (İç İçe If)](#nested-if-işçe-if)
- [Mantıksal Operatörlerle If](#mantıksal-operatörlerle-if)
- [If ile Karar Verme Örneği](#if-ile-karar-verme-örneği)
- [Switch Yapısı](#switch-yapısı)
- [Ternary (Üçlü) Operatör](#ternary-üçlü-operatör)

---

## If Yapısı

`if` yapısı, verilen bir koşul doğruysa belirli bir kod bloğunu çalıştırmak için kullanılır.

```csharp
int x = 50;

if (x > 30)
{
    Console.WriteLine("Sayı 30'dan büyüktür");
}
```

Burada `x` değişkeni 30'dan büyükse ekrana mesaj yazdırılır.

---

## If - Else Yapısı

`if` koşulu sağlanmazsa, `else` bloğu çalıştırılır.

```csharp
int x = 50;

if (x > 60)
{
    Console.WriteLine("Sayı 60'dan büyüktür.");
}
else
{
    Console.WriteLine("Sayı 60'dan küçüktür.");
}
```

---

## If - Else If - Else Yapısı

Birden fazla koşulu kontrol etmek için kullanılır.

```csharp
int x = 10;

if (x == 0)
{
    Console.WriteLine("Sayı 0'dır.");
}
else if (x == 10)
{
    Console.WriteLine("Sayı 10'dur.");
}
else
{
    Console.WriteLine("Sayı 0 ya da 10 değildir.");
}
```

---

## Süslü Parantez Kullanımı Olmadan If

Tek satırlık kodlarda süslü parantez kullanmadan da yazılabilir.

```csharp
int number = 10;

if (number != 0)
    Console.WriteLine("Sayı 0 değildir.");
else
    Console.WriteLine("Sayı 0'dır.");
```

---

## Nested If (İç İçe If)

Bir `if` bloğu içinde başka bir `if` bloğu kullanılabilir.

```csharp
int age = 18;
bool hasLicensed = true;

if (age >= 18)
{
    if (hasLicensed == true)
        Console.WriteLine("Araç kullanabilirsiniz.");
    else
        Console.WriteLine("Araç kullanmak için ehliyet gereklidir.");
}
else
{
    Console.WriteLine("Araç kullanmak için gerekli yaş sınırı 18'dir.");
}
```

---

## Mantıksal Operatörlerle If

Koşulları `&&` (ve), `||` (veya) gibi mantıksal operatörlerle birleştirebiliriz.

```csharp
int number = 200;

if (number >= 0 && number <= 100)
    Console.WriteLine("Sayı 0 ile 100 arasındadır.");
else if (number > 100 && number <= 300)
    Console.WriteLine("Sayı 101 ile 300 arasındadır.");
else 
    Console.WriteLine("Sayı ya 0'dan küçük ya da 300'den büyüktür.");
```

---

## If ile Karar Verme Örneği

Kullanıcıdan alınan sayının çift veya tek olduğunu kontrol eden örnek:

```csharp
Console.Write("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine("Girilen sayı çift sayıdır.");
else
    Console.WriteLine("Girilen sayı tek sayıdır.");
```

---

## Switch Yapısı

Bir değişkenin değerine göre farklı kod bloklarını çalıştırmak için kullanılır.

```csharp
int x = 0;

switch (x)
{
    case 10:
        Console.WriteLine("Sayı 10'dur.");
        break;
    case 0:
        Console.WriteLine("Sayı 0'dır.");
        break;
    default:
        Console.WriteLine("Sayı 10 ya da 0 değildir.");
        break;
}
```

---

## Ternary (Üçlü) Operatör

Kısa `if-else` yapıları için kullanılır. 

```csharp
int y = 50;

Console.WriteLine(y > 40 ? "Sayı 40'dan büyüktür." : "Sayı 40'dan küçüktür.");
```

Burada `y > 40` koşulu doğruysa ilk ifade, değilse ikinci ifade yazdırılır.

---

# Proje Hakkında

Bu örnekler C# dilinin temel kontrol yapılarının öğrenilmesi ve anlaşılması için hazırlanmıştır. Kod içerisindeki yorum satırlarını açarak deneyebilir, değişiklik yaparak farklı durumları test edebilirsiniz.

---

**Geliştirici:** Kaaner  
**Dil:** C#  
**IDE:** Visual Studio 2022  
