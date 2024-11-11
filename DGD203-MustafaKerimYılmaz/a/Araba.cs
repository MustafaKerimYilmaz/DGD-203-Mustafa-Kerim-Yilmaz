using System;

public class Araba
{
   
    public string Marka { get; set; }
    public int Yil { get; set; }
    public string Renk { get; set; }
    

    
    public Araba(string marka, int yil, string renk)
    {
        Marka = marka;
        Yil = yil;
        Renk = renk;
        
    }


    public void BilgiYazdır()
    {
        Console.WriteLine($"Araba Bilgileri: Marka: {Marka}, Yil: {Yil}, Renk: {Renk},");
    }
}
 