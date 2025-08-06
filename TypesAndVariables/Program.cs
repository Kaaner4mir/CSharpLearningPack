class Program
{
    public static void Main()
    {
        // Tam sayı tipleri (Integer Types) 

        byte num1 = 145;
        sbyte num2 = -14;
        short num3 = 23423;
        ushort num4 = 45342;
        int num5 = -135134124;
        uint num6 = 914875913;
        long num7 = -123413498571341234;
        ulong num8 = 2241234091745123413;

        // Ondalıklı sayı tipler (Floating Point Types)

        float num9 = 12.324f;
        double num10 = 1543.28435d;
        decimal num11 = 94846.136946546m;

        // Mantıksal Tip (Boolean)

        bool isTrue = true;

        // Karakter tipi

        char character = 'a';

        // Metin Tipi (Referans Tipi)

        string text = "C# öğreniyorum";

        // Nesne tipi

        object obj = 23;


        Console.WriteLine($"num1: {num1}\n" +
                          $"num2: {num2}\n" +
                          $"num3: {num3}\n" +
                          $"num4: {num4}\n" +
                          $"num5: {num5}\n" +
                          $"num6: {num6}\n" +
                          $"num7: {num7}\n" +
                          $"num8: {num8}\n" +
                          $"num9: {num9}\n" +
                          $"num10: {num10}\n" +
                          $"num11: {num11}\n" +
                          $"isTrue: {isTrue}\n" +
                          $"character: {character}\n" +
                          $"text: {text}\n" +
                          $"obj: {obj}");

        Console.ReadLine();
    }
}