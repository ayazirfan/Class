Calisan calisan1 = new Calisan("Ayşe", "Kahraman", 1120, "İnsan Kaynakları");
Console.WriteLine("************");







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
 public void CalisanBilgileri()
 {
  Console.WriteLine("Çalışanın Adı:{0", Ad);
  Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
  Console.WriteLine("Çalışanın Numarası:{0}", No);
  Console.WriteLine("Çalışanın Departmanı : {0}", Departman);


 }
}
