class Program
{
    public static void Main()
    {
        #region Array

        //int[] numbers = new int[5]
        //{
        //    1,2,3,4,5
        //};

        ////int[] numbers = { 1, 2, 3, 4, 5 };

        //Console.WriteLine(numbers[0]);

        //for (int i = 0; i <= numbers.Length - 1; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}

        //int[,] matrix = {
        //    { 1, 2, 3, 4 },
        //    { 5, 6, 7, 8 },
        //    { 9, 10,11,12 },
        //    { 13,14,15,16 }
        //};

        //// Bölge başlangıç indeksi (satır, sütun)
        //int startRow = 1;
        //int startCol = 1;

        //// Bölge boyutu
        //int regionRows = 2;
        //int regionCols = 3;

        //Console.WriteLine("Seçilen bölge:");

        //for (int i = startRow; i < startRow + regionRows; i++)
        //{
        //    for (int j = startCol; j < startCol + regionCols; j++)
        //    {
        //        Console.Write(matrix[i, j] + "\t");
        //    }
        //    Console.WriteLine();

            #endregion

            #region List

            //List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            //// Add(T item) - Listeye eleman ekle
            //numbers.Add(60);

            //// AddRange(IEnumerable<T>) - Çoklu eleman ekle
            //numbers.AddRange(new int[] { 70, 80 });

            //// Insert(int index, T item) - İndekse eleman ekle
            //numbers.Insert(2, 25);

            //// InsertRange(int index, IEnumerable<T>) - İndekse çoklu eleman ekle
            //numbers.InsertRange(5, new int[] { 35, 37 });

            //// Remove(T item) - İlk eşleşen elemanı sil
            //numbers.Remove(35);

            //// RemoveAt(int index) - Belirtilen indeksteki elemanı sil
            //numbers.RemoveAt(3);

            //// RemoveAll(Predicate<T>) - Şarta uyan tüm elemanları sil
            //numbers.RemoveAll(n => n > 50);

            //// RemoveRange(int index, int count) - Belirtilen aralıktaki elemanları sil
            //numbers.RemoveRange(1, 2);

            //// Contains(T item) - Eleman listede var mı kontrol et
            //bool exists = numbers.Contains(40);
            //Console.WriteLine("40 var mı? " + exists);

            //// IndexOf(T item) - İlk eşleşen elemanın indeksini bul
            //int index = numbers.IndexOf(37);
            //Console.WriteLine("37'nin indeksi: " + index);

            //// LastIndexOf(T item) - Son eşleşen elemanın indeksini bul
            //numbers.Add(40);
            //int lastIndex = numbers.LastIndexOf(40);
            //Console.WriteLine("Son 40'ın indeksi: " + lastIndex);

            //// Find(Predicate<T>) - Şarta uyan ilk elemanı bul
            //int found = numbers.Find(n => n > 30);
            //Console.WriteLine("30'dan büyük ilk sayı: " + found);

            //// FindLast(Predicate<T>) - Şarta uyan son elemanı bul
            //int foundLast = numbers.FindLast(n => n > 30);
            //Console.WriteLine("30'dan büyük son sayı: " + foundLast);

            //// FindIndex(Predicate<T>) - Şarta uyan ilk elemanın indeksini bul
            //int foundIndex = numbers.FindIndex(n => n > 30);
            //Console.WriteLine("30'dan büyük ilk sayının indeksi: " + foundIndex);

            //// FindLastIndex(Predicate<T>) - Şarta uyan son elemanın indeksini bul
            //int foundLastIndex = numbers.FindLastIndex(n => n > 30);
            //Console.WriteLine("30'dan büyük son sayının indeksi: " + foundLastIndex);

            //// Exists(Predicate<T>) - Şarta uyan en az bir eleman var mı kontrol et
            //bool anyMatch = numbers.Exists(n => n == 50);
            //Console.WriteLine("50 var mı? " + anyMatch);

            //// Sort() - Elemanları küçükten büyüğe sırala
            //numbers.Sort();
            //Console.WriteLine("Sıralı liste:");
            //numbers.ForEach(n => Console.Write(n + " "));
            //Console.WriteLine();

            //// Sort(Comparison<T>) - Kendi kıyaslama fonksiyonunla sırala (büyükten küçüğe)
            //numbers.Sort((a, b) => b.CompareTo(a));
            //Console.WriteLine("Büyükten küçüğe sıralı liste:");
            //numbers.ForEach(n => Console.Write(n + " "));
            //Console.WriteLine();

            //// Reverse() - Listenin eleman sırasını tersine çevir
            //numbers.Reverse();
            //Console.WriteLine("Ters çevrilmiş liste:");
            //numbers.ForEach(n => Console.Write(n + " "));
            //Console.WriteLine();

            //// ToArray() - Listeyi diziye dönüştür
            //int[] array = numbers.ToArray();
            //Console.WriteLine("Dizi elemanları:");
            //foreach (var item in array)
            //    Console.Write(item + " ");
            //Console.WriteLine();

            //// GetRange(int index, int count) - Belirtilen aralıktaki elemanlarla yeni liste oluştur
            //List<int> sublist = numbers.GetRange(1, 3);
            //Console.WriteLine("Alt liste elemanları:");
            //sublist.ForEach(n => Console.Write(n + " "));
            //Console.WriteLine();

            //// ConvertAll<TResult>(Converter<T, TResult>) - Elemanları başka tipe dönüştür
            //List<string> stringList = numbers.ConvertAll(n => "Sayı: " + n);
            //Console.WriteLine("Dönüştürülmüş liste:");
            //stringList.ForEach(s => Console.WriteLine(s));

            //// Count - Listenin eleman sayısı
            //Console.WriteLine("Eleman sayısı: " + numbers.Count);

            //// Capacity - Listenin kapasitesi (önceden ayrılan alan)
            //Console.WriteLine("Kapasite: " + numbers.Capacity);

            //// TrimExcess() - Kapasiteyi gerçek eleman sayısına indir
            //numbers.TrimExcess();
            //Console.WriteLine("TrimExcess sonrası kapasite: " + numbers.Capacity);

            #endregion

            #region Dictionary

            //// Dictionary oluşturma
            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //// Eleman ekleme
            //ages.Add("Ali", 25);                // Add metodu
            //ages["Ayşe"] = 30;                  // Indexer ile ekleme veya güncelleme

            //// Eleman erişimi
            //int aliAge = ages["Ali"];           // Direkt erişim (anahtar varsa)
            //Console.WriteLine("Ali'nin yaşı: " + aliAge);

            //// TryGetValue ile güvenli erişim
            //if (ages.TryGetValue("Ayşe", out int ayseAge))
            //{
            //    Console.WriteLine("Ayşe'nin yaşı: " + ayseAge);
            //}
            //else
            //{
            //    Console.WriteLine("Ayşe bulunamadı.");
            //}

            //// Eleman güncelleme
            //ages["Ali"] = 26;                   // Ali'nin yaşını güncelle

            //// Eleman silme
            //bool removed = ages.Remove("Ayşe"); // Ayşe'yi sil, başarılı mı kontrol et
            //Console.WriteLine("Ayşe silindi mi? " + removed);

            //// Anahtar kontrolü
            //bool hasAli = ages.ContainsKey("Ali");
            //Console.WriteLine("Ali var mı? " + hasAli);

            //// Değer kontrolü
            //bool hasAge25 = ages.ContainsValue(25);
            //Console.WriteLine("25 yaşı var mı? " + hasAge25);

            //// Eleman sayısı
            //Console.WriteLine("Eleman sayısı: " + ages.Count);

            //// Döngü ile gezme
            //foreach (KeyValuePair<string, int> kvp in ages)
            //{
            //    Console.WriteLine($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
            //}

            //// Keys ve Values koleksiyonları
            //ICollection<string> keys = ages.Keys;
            //ICollection<int> values = ages.Values;

            //Console.WriteLine("Anahtarlar:");
            //foreach (var key in keys)
            //    Console.WriteLine(key);

            //Console.WriteLine("Değerler:");
            //foreach (var value in values)
            //    Console.WriteLine(value);

            //// Clear metodu - Tüm elemanları siler
            //ages.Clear();
            //Console.WriteLine("Eleman sayısı (Clear sonrası): " + ages.Count);

            #endregion

            #region HashSet

            HashSet<string> fruits = new HashSet<string>();

            // Eleman ekleme
            bool addedApple = fruits.Add("apple");    // true
            bool addedBanana = fruits.Add("banana");  // true
            bool addedAppleAgain = fruits.Add("apple"); // false (zaten var)

            Console.WriteLine($"Elma eklendi mi? {addedApple}");
            Console.WriteLine($"Muz eklendi mi? {addedBanana}");
            Console.WriteLine($"Elma tekrar eklendi mi? {addedAppleAgain}");

            // Eleman kontrolü
            Console.WriteLine("Muz var mı? " + fruits.Contains("banana"));

            // Eleman silme
            fruits.Remove("banana");

            Console.WriteLine("Eleman sayısı: " + fruits.Count);

            // Küme işlemleri
            HashSet<string> tropicalFruits = new HashSet<string> { "banana", "pineapple", "mango" };

            // Birleşim
            fruits.UnionWith(tropicalFruits);
            Console.WriteLine("Birleşim sonrası:");
            foreach (var fruit in fruits)
                Console.WriteLine(fruit);

            // Kesişim
            fruits.IntersectWith(new List<string> { "apple", "mango" });
            Console.WriteLine("Kesişim sonrası:");
            foreach (var fruit in fruits)
                Console.WriteLine(fruit);

            #endregion

            Console.ReadLine();
        }
    }
}