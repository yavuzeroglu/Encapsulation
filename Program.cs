using System;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="Yavuz";
            ogrenci.Soyisim ="Eroglu";
            ogrenci.OgrenciNo=184;
            ogrenci.Sınıf=11;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Bağdaş",256,1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci 
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sınıf;

        public string Isim { 
            get { return isim; }
            set { isim=value; }
            }
        public string Soyisim { 
            get => soyisim;
            set => soyisim = value;
            }
        public int OgrenciNo { 
            get => ogrenciNo; 
            set => ogrenciNo = value; 
            }
        public int Sınıf { 
            get => sınıf;
            set{
                if(value <1) {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sınıf=1;
                } else sınıf = value;
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sınıf)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sınıf = sınıf;
        }
        public Ogrenci(){
            
        }
        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("***** Ogrenci Bilgileri ****");
            Console.WriteLine
                ("Ogrencinin Adı :{0}",Isim);
            Console.WriteLine
                ("Ogrencinin Soyadı :{0}",Soyisim);
            Console.WriteLine
                ("Ogrencinin Numarası :{0}",OgrenciNo);
            Console.WriteLine
                ("Ogrencinin Sınıfı :{0}",Sınıf);
        }
        public void SinifAtlat()
        {
            this.Sınıf = this.Sınıf+1;
        }
        public void SinifDusur(){
            this.Sınıf = this.Sınıf-1;
            
        }
    }
}