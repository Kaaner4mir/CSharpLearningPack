# 🧠 C# Types and Variables — Konu Özeti

## ✅ 1. Değişken (Variable) Nedir?

- Bellekte veri tutmak için kullanılan isimlendirilmiş alanlardır.
- Bir değişkenin **veri türü (type)**, içine ne tür veri koyulabileceğini belirler.

```csharp
int yas = 25;
string isim = "Kaaner";
```

---

## 🧮 2. Veri Türleri (Data Types)

C#’ta veri türleri iki ana gruba ayrılır:

### 🟩 a) Değer Tipleri (Value Types)
Veri doğrudan değişkenin içinde saklanır.

| Tür       | Açıklama                                 | Örnek          |
|-----------|-------------------------------------------|----------------|
| `int`     | Tam sayı                                  | `int x = 10;`  |
| `double`  | Ondalıklı sayı                            | `double d = 3.14;` |
| `bool`    | Doğru/yanlış (true/false)                 | `bool b = true;` |
| `char`    | Tek bir karakter                          | `char c = 'A';` |
| `decimal` | Finansal işlemler için ondalıklı sayı     | `decimal m = 5.99m;` |
| `float`   | Daha düşük hassasiyetli ondalıklı sayı    | `float f = 3.14f;` |
| `long`    | Çok büyük tam sayılar                     | `long l = 123456789L;` |

### 🟦 b) Referans Tipleri (Reference Types)
Veri bellekte farklı bir yerde tutulur, değişken sadece adresini taşır.

| Tür       | Açıklama                          | Örnek                |
|-----------|----------------------------------|----------------------|
| `string`  | Metin dizisi                     | `string s = "Merhaba";` |
| `object`  | Tüm türlerin atası, her şeyi alır| `object o = 5;`      |
| `array`   | Dizi                             | `int[] sayilar = {1,2};` |

---

## 🔢 3. Sayısal Veri Türleri ve Boyutları

| Tür     | Bit | Açıklama                        |
|---------|-----|----------------------------------|
| `byte`  | 8   | 0-255 arası pozitif tam sayı     |
| `sbyte` | 8   | -128 ile 127 arası               |
| `short` | 16  | Küçük negatif/pozitif tam sayı   |
| `ushort`| 16  | 0 ile 65.535                     |
| `int`   | 32  | En yaygın tam sayı türü          |
| `uint`  | 32  | 0 ile 4 milyar arası             |
| `long`  | 64  | Büyük tam sayılar için           |
| `ulong` | 64  | Pozitif büyük tam sayılar        |

---

## 🔤 4. Unicode Karakter Nedir?

- Unicode, tüm dillerdeki karakterleri temsil eden evrensel bir standarttır.
- C#’ta `char` tipi Unicode karakter saklar.
- Örnek:

```csharp
char ch = 'ç'; // Unicode karakter
char ch2 = 'Ω'; // Omega: Ω
```

---

## 📌 Notlar

- `float`, `decimal` ve `double` gibi tiplerde son harf (`f`, `m`, `d`) gereklidir.
- `object` en genel türdür, tüm türler onun içine atanabilir.
- `char` ve `string` Unicode desteği sağlar.

---

## 🧪 Öneri

Bu bilgileri pekiştirmek için küçük kod örnekleriyle kendi test projeni oluşturabilirsin. Her veri türü için Console çıktısı alarak nasıl çalıştığını gözlemle!
