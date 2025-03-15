using System; // using System; ifadesi temel C# komutlarını kullanabilmemiz için gereklidir.
// Örneğin Console sınıfı System kütüphanesi içindedir.

namespace MerhabaDunya // namespace: Projemizin adını belirler, aynı isimde sınıflar karışmasın diye kullanılır.
{
    class Program // class Program: Programımızın başladığı ana sınıftır.
    {
        static void Main(string[] args) // static void Main: Programın ilk çalışan (ana) metodudur.
        {
            Console.WriteLine("Merhaba, Dünya!"); // Console.WriteLine: Ekrana yazı yazdırır.
            // Bu komut sayesinde ekranda "Merhaba, Dünya!" görünür.

            Console.WriteLine("Çıkmak için bir tuşa basınız..."); // Kullanıcıya çıkış için bilgi verir.
            Console.ReadKey(); // Kullanıcıdan bir tuşa basmasını bekler, yoksa program hemen kapanır.
        }
    }
}
