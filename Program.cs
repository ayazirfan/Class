Calisan calisan1 = new Calisan("Ayşe", "Kahraman", 1120, "İnsan Kaynakları");
System.Console.WriteLine("******Çalışan 1*****");
calisan1.CalisanBilgileri();

Console.WriteLine("************");
Calisan calisan2 = new Calisan("Deniz", "Arda", 2324, "Lojistik");
System.Console.WriteLine("******Çalışan 2*****");
calisan2.CalisanBilgileri();

Calisan calisan3 = new Calisan("Deniz", "Arda");
System.Console.WriteLine("******Çalışan 3*****");
calisan3.CalisanBilgileri();







class Calisan
{
  public string Ad;
  public string Soyad;
  public int No;
  public string Departman;

 public Calisan( string ad, string soyad, int no, string departman)
 {
   this.Ad = ad;
   this.Soyad = soyad;
   this.No = no;
   this.Departman = departman;
 } 
 public Calisan(string ad, string soyad)
 {
  this.Ad = ad;
  this.Soyad = soyad;
 }
 public void CalisanBilgileri()
 {
  Console.WriteLine("Çalışanın Adı:{0}", Ad);
  Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
  Console.WriteLine("Çalışanın Numarası:{0}", No);
  Console.WriteLine("Çalışanın Departmanı : {0}", Departman);


 }
}
