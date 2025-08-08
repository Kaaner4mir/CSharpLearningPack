
# C# Koleksiyonlar Notları

Bu dosya, C# dilinde sık kullanılan **Array**, **List**, **Dictionary** ve **HashSet** koleksiyonlarının temel kullanımını, önemli metotlarını ve özelliklerini özetler.

---

## 1. Array (Dizi)

- **Tanım:** Sabit boyutlu, aynı türden elemanları tutan veri yapısıdır.
- **Tanımlama:**

```csharp
int[] numbers = new int[5] {1, 2, 3, 4, 5};
// veya
int[] numbers = {1, 2, 3, 4, 5};
```

- **Erişim:** `numbers[index]` ile yapılır.
- **Döngü ile erişim:**

```csharp
for (int i = 0; i < numbers.Length; i++) { Console.WriteLine(numbers[i]); }

foreach (var num in numbers) { Console.WriteLine(num); }
```

- **Çok boyutlu diziler:**

```csharp
int[,] matrix = {
  {1, 2, 3},
  {4, 5, 6}
};
```

- Çok boyutlu dizide belli bir bölge seçip yazdırma mümkündür.

---

## 2. List<T> (Liste)

- **Tanım:** Dinamik boyutlu, generic koleksiyon. Eleman ekleme, çıkarma, arama gibi işlemler kolaydır.
- **Oluşturma:**

```csharp
List<int> numbers = new List<int> { 10, 20, 30 };
```

- **Eleman ekleme:**
  - `Add(item)` — Tek eleman ekler.
  - `AddRange(IEnumerable<T>)` — Çoklu eleman ekler.
  - `Insert(index, item)` — Belirli indekse ekler.
  - `InsertRange(index, IEnumerable<T>)` — Çoklu elemanı belirli indekse ekler.

- **Eleman silme:**
  - `Remove(item)` — İlk eşleşeni siler.
  - `RemoveAt(index)` — Belirtilen indeksteki elemanı siler.
  - `RemoveAll(Predicate<T>)` — Şarta uyan tüm elemanları siler.
  - `RemoveRange(index, count)` — Belirtilen aralıktaki elemanları siler.

- **Arama ve kontrol:**
  - `Contains(item)` — Eleman var mı kontrolü.
  - `IndexOf(item)`, `LastIndexOf(item)` — Elemanın indeksini bulur.
  - `Find(Predicate<T>)`, `FindLast(Predicate<T>)` — Şarta uyan ilk/son elemanı bulur.
  - `FindIndex(Predicate<T>)`, `FindLastIndex(Predicate<T>)` — Şarta uyan ilk/son elemanın indeksini bulur.
  - `Exists(Predicate<T>)` — Şarta uyan en az bir eleman var mı kontrol eder.

- **Sıralama ve düzenleme:**
  - `Sort()` — Küçükten büyüğe sıralar.
  - `Sort(Comparison<T>)` — Kendi karşılaştırma fonksiyonunu kullanarak sıralar.
  - `Reverse()` — Listeyi tersine çevirir.

- **Diğer:**
  - `ToArray()` — Listeyi diziye dönüştürür.
  - `GetRange(index, count)` — Belirtilen aralıktaki elemanlarla yeni liste oluşturur.
  - `ConvertAll<TResult>(Converter<T, TResult>)` — Elemanları başka tipe dönüştürür.
  - `Count` — Eleman sayısı.
  - `Capacity` — Liste kapasitesi (önceden ayrılan alan).
  - `TrimExcess()` — Kapasiteyi gerçek eleman sayısına indirger.

---

## 3. Dictionary<TKey, TValue> (Sözlük)

- **Tanım:** Anahtar-değer çiftlerini tutan koleksiyon. Anahtarlar benzersizdir.
- **Oluşturma:**

```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();
```

- **Eleman ekleme:**
  - `Add(key, value)` — Anahtar ve değer ekler.
  - `ages[key] = value` — Anahtar ile değer ekler veya günceller.

- **Erişim:**
  - `ages[key]` — Değeri alır (anahtar yoksa hata verir).
  - `TryGetValue(key, out value)` — Güvenli erişim sağlar.

- **Güncelleme:**
  - `ages[key] = newValue;`

- **Silme:**
  - `Remove(key)` — Anahtarla eşleşen öğeyi siler.

- **Kontrol:**
  - `ContainsKey(key)` — Anahtar var mı?
  - `ContainsValue(value)` — Değer var mı?

- **Diğer:**
  - `Count` — Eleman sayısı.
  - Döngü ile tüm anahtar-değer çiftlerine erişim:

```csharp
foreach(var kvp in ages)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}
```

- `Keys` ve `Values` koleksiyonları ile sadece anahtarlar veya değerler alınabilir.

- `Clear()` — Tüm elemanları temizler.

---

## 4. HashSet<T> (Küme)

- **Tanım:** Benzersiz elemanlar tutan koleksiyon. Kesişim, birleşim, fark gibi küme işlemlerinde kullanılır.
- **Oluşturma:**

```csharp
HashSet<string> fruits = new HashSet<string>();
```

- **Eleman ekleme:**
  - `Add(item)` — Elemanı ekler, zaten varsa eklemez ve `false` döner.

- **Eleman kontrolü:**
  - `Contains(item)`

- **Eleman silme:**
  - `Remove(item)`

- **Küme işlemleri:**
  - `UnionWith(IEnumerable<T>)` — Birleşim.
  - `IntersectWith(IEnumerable<T>)` — Kesişim.
  - `ExceptWith(IEnumerable<T>)` — Fark.
  - `SymmetricExceptWith(IEnumerable<T>)` — Simetrik fark.

- **Örnek:**

```csharp
fruits.UnionWith(new[] {"banana", "pineapple"});
fruits.IntersectWith(new[] {"apple", "mango"});
```

---

# Özet

| Koleksiyon    | Özellik                                     | Kullanım Alanı                      |
|---------------|---------------------------------------------|-----------------------------------|
| **Array**     | Sabit boyut, hızlı, çok boyutlu destekler  | Sabit veri setleri, matris işlemleri |
| **List<T>**   | Dinamik, sıralama ve filtreleme destekler  | Veri listeleri, dinamik veri yönetimi |
| **Dictionary<TKey, TValue>** | Anahtar-değer çifti, hızlı arama  | Anahtarla hızlı erişim gereken durumlar |
| **HashSet<T>**| Benzersiz elemanlar, küme işlemleri         | Benzersiz veri tutma, küme mantığı |

---

Bu notları Visual Studio 2022 ile C# öğrenirken veya projelerinde koleksiyonlarla çalışırken referans olarak kullanabilirsin. İstersen örnek kodlarla da genişletip, pratik yapabilirsin.

İyi öğrenmeler! 🚀
