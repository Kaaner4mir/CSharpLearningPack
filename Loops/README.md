# 🔁 C# Loop (Döngüler) Örnekleri

Bu proje, C# dilinde kullanılan temel döngü yapılarının (`for`, `while`, `do-while`, `foreach`) ve döngü kontrol komutlarının (`break`, `continue`) nasıl çalıştığını öğretmek amacıyla hazırlanmıştır.  
Kodlar yorum satırı olarak yerleştirilmiştir. Her bir örnek tek tek açılıp çalıştırılarak test edilebilir.

---

## 🧠 Kullanılan Konular

- `for` döngüsü
- `while` döngüsü
- `do-while` döngüsü
- `foreach` döngüsü
- `break` komutu
- `continue` komutu

---

## 🔹 1. `for` Döngüsü

`for` döngüsü, başlangıç değeri, koşul ve artırma/azaltma adımı ile çalışan klasik bir sayaçlı döngüdür.

### 📌 Örnek:

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

> Bu örnekte, `i` değişkeni 0'dan başlayarak 10'dan küçük olduğu sürece 1'er artarak konsola yazdırılır.

---

## 🔹 2. `while` Döngüsü

Koşul sağlandığı sürece dönen bir döngüdür. Koşul başta kontrol edilir.

### 📌 Örnek:

```csharp
int y = 2;

while (y < 20)
{
    Console.WriteLine(y);
    y = y + 2;
}
```

> `y` 2'den başlayarak 20'den küçük olduğu sürece 2'şer artarak yazdırılır.

---

## 🔹 3. `do-while` Döngüsü

`while` gibi çalışır ama **en az bir kez** çalışır çünkü koşul **sonradan** kontrol edilir.

### 📌 Örnek:

```csharp
int z = 10;

do
{
    Console.WriteLine(z);
}
while (z > 15);
```

> Koşul sağlanmasa bile bir kez çalışır. Bu örnekte `z > 15` olmadığı hâlde bir kez yazdırılır.

---

## 🔹 4. `foreach` Döngüsü

Diziler ve koleksiyonlar üzerinde dolaşmak için kullanılır. Elemanlara tek tek ulaşılır.

### 📌 Örnek:

```csharp
int[] number = {1, 2, 3, 4, 5};

foreach (var item in number)
{
    Console.WriteLine(item);
}
```

> Bu döngü dizideki tüm elemanları sırasıyla ekrana yazdırır.

---

## 🧨 5. `break` Komutu

Döngüyü anında sonlandırmak için kullanılır.

### 📌 Örnek:

```csharp
for (int i = 0; i < 20; i++)
{
    if (i == 10)
    {
        break;
    }
    Console.WriteLine(i);
}
```

> `i` 10 olduğunda döngü tamamen durur, 0'dan 9'a kadar sayılar yazdırılır.

---

## 🔁 6. `continue` Komutu

Döngünün o anki adımını atlamak için kullanılır, sonraki adıma geçilir.

### 📌 Örnek:

```csharp
for (int i = 0; i < 20; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine(i);
}
```

> Yalnızca çift sayılar yazdırılır. Tek sayılar atlanır.

---

## 📚 Öğrenilenler

- Döngülerin farklı çalışma yapıları
- Koşul bazlı döngü kontrolü
- Dizi ve koleksiyonlarda `foreach` kullanımı
- Döngü akışını `break` ve `continue` ile değiştirme

---

## 💻 Gereksinimler

- .NET SDK (7.0 veya üstü)
- Visual Studio 2022
- Konsol uygulaması (Console App)

---

## ▶️ Çalıştırma

Visual Studio'da `Program.cs` dosyasındaki her bölümü sırayla açarak test edebilirsiniz.  
Yalnızca bir döngü türü açık olmalıdır, diğerleri yorum satırı (//) olarak kalmalıdır.

---

## 📄 Lisans

MIT Lisansı ile paylaşılmıştır.  
Kodları inceleyebilir, öğrenme amaçlı kullanabilirsiniz.