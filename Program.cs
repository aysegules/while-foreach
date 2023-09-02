internal class Program
{
    public static void Main(string[] args)
    {
        //While
        //1'den baslayarak console'dan girilen sayiya kadar(sayilar dahil) ortalama hesaplayip console'a yazdiran program

        Console.WriteLine("Lutfen bir sayi giriniz:");
        int sayi=int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam=0;

        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;   
        }

        double ortalama=toplam/sayi;        
        Console.WriteLine(ortalama);

        // a'dan z'ye kadar tum harfleri console'a yazdiran program
        char karakter='a';
        while (karakter <= 'z')
        {
            Console.WriteLine(karakter);
            karakter++;
        }

        //ForEach

        string[] arabalar={"Volkswagen","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
           Console.WriteLine(araba); 
        }

    }
}