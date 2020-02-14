using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Data;


namespace İlaçEczaOtomasyonu
{

    public partial class Grid : System.Web.UI.Page
    {
        EczaDepoEntities1 ECZADEPO = new EczaDepoEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label10.Text = "ECZA DEPOSU OTOMASYONU";
            Label1.Visible = false;
            TextBox1.Visible = false;
            Label2.Visible = false;
            TextBox2.Visible = false;
            Label3.Visible = false;
            TextBox3.Visible = false;
            Label4.Visible = false;
            TextBox4.Visible = false;
            Label5.Visible = false;
            TextBox5.Visible = false;
            Label6.Visible = false;
            TextBox6.Visible = false;
            Label7.Visible = false;
            TextBox7.Visible = false;
            Label8.Visible = false;
            TextBox8.Visible = false;
            Label9.Visible = false;
            TextBox9.Visible = false;
            
       
            Buton_Ara.Visible = false;
            Buton_Ara0.Visible = false;
            Buton_Ara1.Visible = false;
            Buton_Ara2.Visible = false;
            Buton_Ara3.Visible = false;
            
            Buton_Ekle.Visible = false;
            Buton_Ekle0.Visible = false;
            Buton_Ekle1.Visible = false;
            Buton_Ekle2.Visible = false;
            Buton_Ekle3.Visible = false;
           
            Buton_Sil.Visible = false;
            Buton_Sil0.Visible = false;
            Buton_Sil1.Visible = false;
            Buton_Sil2.Visible = false;
            Buton_Sil3.Visible = false;
            
            Buton_Guncelle.Visible = false;
            Buton_Guncelle0.Visible = false;
            Buton_Guncelle1.Visible = false;
            Buton_Guncelle2.Visible = false;
            Buton_Guncelle3.Visible = false;
        }


        
        protected void Buton_Musteriler_Click(object sender, EventArgs e)
        {
           
            GridView1.Visible = true;
            GridView1.DataSource = ECZADEPO.Musteri.ToList();
            GridView1.DataBind();
            Label1.Visible = true;
            Label1.Text = "Müşteri ID'si=";
            TextBox1.Visible = true;
            Label2.Visible = true;
            Label2.Text = "Müşteri Adı=";
            TextBox2.Visible = true;
            Label3.Visible = true;
            Label3.Text = "Müşteri Soyadı=";
            TextBox3.Visible = true;
            Label4.Visible = true;
            Label4.Text = "Müşteri Telefonu=";
            TextBox4.Visible = true;
            Label5.Visible = true;
            Label5.Text = "Çalıştığı Kişinin ID'si=";
            TextBox5.Visible = true;

            
            Buton_Guncelle.Visible = true;
            Buton_Ekle.Visible = true;
            Buton_Sil.Visible = true;
            Buton_Ara.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

            
        }
        protected void Buton_Calisanlar_Click(object sender, EventArgs e)
        {
            
            GridView1.Visible = true;
          
            Label1.Visible = true;
            Label1.Text = "Çalışan ID'si=";
            TextBox1.Visible = true;
            Label2.Visible = true;
            Label2.Text = "Çalışan Adı=";
            TextBox2.Visible = true;
            Label3.Visible = true;
            Label3.Text = "Çalışan Soyadı=";
            TextBox3.Visible = true;
            Label4.Visible = true;
            Label4.Text = "Çalışan Telefonu=";
            TextBox4.Visible = true;
            Label5.Visible = true;
            Label5.Text = "Çalışan Emaili=";
            TextBox5.Visible = true;
            Label6.Visible = true;
            Label6.Text = "Çalışanın Görevi=";
            TextBox6.Visible = true;
            Label7.Visible = true;
            Label7.Text = "Çalışanın İşe Giriş Tarihi=";
            TextBox7.Visible = true;
            Label8.Visible = true;
            Label8.Text = "Çalışan Maaşı=";
            TextBox8.Visible = true;
            Label9.Visible = true;
            Label9.Text = "Çalışanın Çalıştığı Sube ID'si=";
            TextBox9.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

            GridView1.DataSource = ECZADEPO.Calisan.ToList();
            GridView1.DataBind();

            Buton_Guncelle0.Visible = true;
            Buton_Ekle0.Visible = true;
            Buton_Sil0.Visible = true;
            Buton_Ara0.Visible = true;

        }
        protected void Buton_Ilaclar_Click(object sender, EventArgs e)
        {
            
            Buton_Guncelle1.Visible = true;
            Buton_Ekle1.Visible = true;
            Buton_Sil1.Visible = true;
            Buton_Ara1.Visible = true;
            GridView1.Visible = true;
            
            Label1.Visible = true;
            Label1.Text = "İlacın ID'si=";
            TextBox1.Visible = true;
            Label2.Visible = true;
            Label2.Text = "İlacın Adı=";
            TextBox2.Visible = true;
            Label3.Visible = true;
            Label3.Text = "İlacın Fiyatı=";
            TextBox3.Visible = true;
            Label4.Visible = true;
            Label4.Text = "İlacın Stok Adeti=";
            TextBox4.Visible = true;
            Label5.Visible = true;
            Label5.Text = "İlacın Üretim Tarihi=";
            TextBox5.Visible = true;
            Label6.Visible = true;
            Label6.Text = "İlacın Son Tüketim Tarihi=";
            TextBox6.Visible = true;
            Label7.Visible = true;
            Label7.Text = "Genel Bilgi=";
            TextBox7.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

            GridView1.DataSource = ECZADEPO.Ilac.ToList();
            GridView1.DataBind();
        }
        protected void Buton_Subeler_Click(object sender, EventArgs e)
        {
          
            Buton_Guncelle2.Visible = true;
            Buton_Ekle2.Visible = true;
            Buton_Sil2.Visible = true;
            Buton_Ara2.Visible = true;
            GridView1.Visible = true;
            
            Label1.Visible = true;
            Label1.Text = "Şube ID'si=";
            TextBox1.Visible = true;
            Label2.Visible = true;
            Label2.Text = "Şube Adı=";
            TextBox2.Visible = true;
            Label3.Visible = true;
            Label3.Text = "Şube Adresi=";
            TextBox3.Visible = true;
            Label4.Visible = true;
            Label4.Text = "Şubede Çalışan Kişi Sayısı=";
            TextBox4.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

            GridView1.DataSource = ECZADEPO.Sube.ToList();
            GridView1.DataBind();
        }
        protected void Buton_SatisListesi_Click(object sender, EventArgs e) 
        {
            Buton_Sil3.Visible = true;
            Buton_Guncelle3.Visible = true;
            Buton_Ekle3.Visible = true;
            Buton_Ara3.Visible = true;
            GridView1.Visible = true;
            Label1.Visible = true;
            Label1.Text = "Satışın ID'si=";
            TextBox1.Visible = true;
            Label2.Visible = true;
            Label2.Text = "Çalışan ID'si=";
            TextBox2.Visible = true;
            Label3.Visible = true;
            Label3.Text = "Müşteri ID'si=";
            TextBox3.Visible = true;
            Label4.Visible = true;
            Label4.Text = "İlacın ID'si=";
            TextBox4.Visible = true;
            Label5.Visible = true;
            Label5.Text = "Satış Adeti=";
            TextBox5.Visible = true;
            Label6.Visible = true;
            Label6.Text = "Satış Kazancı=";
            TextBox6.Visible = true;
            Label7.Visible = true;
            Label7.Text = "Satış Tarihi=";
            TextBox7.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

            GridView1.DataSource = ECZADEPO.Satis.ToList();
            GridView1.DataBind();
        }




        protected void Buton_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(TextBox1.Text);
                var güncelle = ECZADEPO.Musteri.Where(w => w.idMUSTERI == value).FirstOrDefault();
                if (TextBox2.Text != "")

                    güncelle.Ad = TextBox2.Text;

                if (TextBox3.Text != "")
                    güncelle.Soyad = TextBox3.Text;

                if (TextBox4.Text != "")
                    güncelle.Telefon = TextBox4.Text;
                if (TextBox5.Text != "")
                {
                    güncelle.CalisanID = Convert.ToInt32(TextBox5.Text);
                }
                if (value <= 0 || Convert.ToInt32(TextBox5.Text) <= 0)
                {
                    Response.Write("ID veya ÇalışanID negatif olamaz.");
                    return;
                }
                ECZADEPO.SaveChanges();
            }
            
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        }   //MUSTERİ
        protected void Buton_Guncelle0_Click0(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(TextBox1.Text);
                var güncelle = ECZADEPO.Calisan.Where(w => w.idCALISAN == value).FirstOrDefault();
                if (TextBox2.Text != "")

                    güncelle.Ad = TextBox2.Text;

                if (TextBox3.Text != "")
                    güncelle.Soyad = TextBox3.Text;

                if (TextBox4.Text != "")
                    güncelle.Telefon = TextBox4.Text;

                if (TextBox5.Text != "")
                    güncelle.Email = TextBox5.Text;

                if (TextBox6.Text != "")
                    güncelle.Görev = TextBox6.Text;

                if (TextBox7.Text != "")
                    güncelle.IseGirisTarihi = TextBox7.Text;

                if (TextBox8.Text != "")
                    güncelle.Maas = Convert.ToInt32(TextBox8.Text);
                if (TextBox9.Text != "")
                    güncelle.SubeID = Convert.ToInt32(TextBox9.Text);
                if (value <= 0 || Convert.ToInt32(TextBox8.Text) <= 0 || Convert.ToInt32(TextBox9.Text) <= 0)
                {
                    Response.Write("ID,Maaş,SubeID Negatif Olamaz.");
                    return;

                }
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //CALISAN
        protected void Buton_Guncelle1_Click1(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(TextBox1.Text);
                var güncelle = ECZADEPO.Ilac.Where(w => w.idILAC == value).FirstOrDefault();
                if (TextBox2.Text != "")

                    güncelle.Ad = TextBox2.Text;

                if (TextBox3.Text != "")
                    güncelle.Fiyat = Convert.ToInt32(TextBox3.Text);

                if (TextBox4.Text != "")
                    güncelle.StokAdet = Convert.ToInt32(TextBox4.Text); ;

                if (TextBox5.Text != "")
                    güncelle.UretimTarihi = TextBox5.Text;

                if (TextBox6.Text != "")
                    güncelle.SonKullanmaTarihi = TextBox6.Text;

                if (TextBox7.Text != "")
                    güncelle.GenelBilgi = TextBox7.Text;
                if (value <= 0 || Convert.ToInt32(TextBox3.Text) <= 0 || Convert.ToInt32(TextBox4.Text) <= 0)
                {
                    Response.Write("ID,Fiyat,Stok Adeti Negatif Olamaz.");
                    return;

                }
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //ILACLAR
        protected void Buton_Guncelle2_Click2(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(TextBox1.Text);
                var güncelle = ECZADEPO.Sube.Where(w => w.idSUBE == value).FirstOrDefault();
                if (TextBox2.Text != "")

                    güncelle.Ad = TextBox2.Text;

                if (TextBox3.Text != "")
                    güncelle.Adres = TextBox3.Text;

                if (TextBox4.Text != "")
                    güncelle.CalisanKisiSayisi = Convert.ToInt32(TextBox4.Text);

                if (value <= 0 || Convert.ToInt32(TextBox3.Text) <= 0 || Convert.ToInt32(TextBox4.Text) <= 0)
                {
                    Response.Write("ID,Çalışan Kişi Sayısı Negatif Olamaz.");
                    return;

                }
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //SUBELER
        protected void Buton_Guncelle3_Click3(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(TextBox1.Text);
                var güncelle = ECZADEPO.Satis.Where(w => w.idSATIS == value).FirstOrDefault();
                if (TextBox2.Text != "")

                    güncelle.CalisanID = Convert.ToInt32(TextBox2.Text);

                if (TextBox3.Text != "")
                    güncelle.MusteriID = Convert.ToInt32(TextBox3.Text);

                if (TextBox4.Text != "")
                    güncelle.IlacID = Convert.ToInt32(TextBox4.Text);
                if (TextBox5.Text != "")
                    güncelle.Adet = Convert.ToInt32(TextBox5.Text);
                if (TextBox6.Text != "")
                    güncelle.Kazanc = Convert.ToInt32(TextBox6.Text);
                if (TextBox7.Text != "")
                    güncelle.Tarih = TextBox7.Text;

                if (value <= 0 || Convert.ToInt32(TextBox2.Text) <= 0 || Convert.ToInt32(TextBox3.Text) <= 0 || Convert.ToInt32(TextBox4.Text) <= 0 || Convert.ToInt32(TextBox5.Text) <= 0)
                {
                    Response.Write("ID,ÇalışanID,MüşteriID,IlacID,Adet,Kazanc Negatif Olamaz.");
                    return;

                }
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //SATISLISTESI



        protected void Buton_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri m1 = new Musteri();

                m1.idMUSTERI = Convert.ToInt32(TextBox1.Text);
                m1.Ad = TextBox2.Text;
                m1.Soyad = TextBox3.Text;
                m1.Telefon = TextBox4.Text;
                m1.CalisanID = Convert.ToInt32(TextBox5.Text);
                if (m1.idMUSTERI < 0 || m1.CalisanID <= 0)
                {
                    Response.Write("ID veya ÇalışanID negatif olamaz.");
                    return;
                }

                ECZADEPO.Musteri.Add(m1);
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }


        }   //MUSTERİ
        protected void Buton_Ekle0_Click0(object sender, EventArgs e)
        {
            try
            {
                Calisan c1 = new Calisan();

                c1.idCALISAN = Convert.ToInt32(TextBox1.Text);
                c1.Ad = TextBox2.Text;
                c1.Soyad = TextBox3.Text;
                c1.Telefon = TextBox4.Text;
                c1.Email = TextBox5.Text;
                c1.Görev = TextBox6.Text;
                c1.IseGirisTarihi = TextBox7.Text;
                c1.Maas = Convert.ToInt32(TextBox8.Text);
                c1.SubeID = Convert.ToInt32(TextBox9.Text);
                if (c1.idCALISAN < 0 || c1.Maas <= 0 || c1.SubeID < 0)
                {
                    Response.Write("ID,Maaş,SubeID Negatif Olamaz.");
                    return;

                }


                ECZADEPO.Calisan.Add(c1);
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";
                Response.Write(mesaj);

            }
        } //CALISAN
        protected void Buton_Ekle1_Click1(object sender, EventArgs e)
        {
            try
            {
                Ilac i1 = new Ilac();

                i1.idILAC = Convert.ToInt32(TextBox1.Text);
                i1.Ad = TextBox2.Text;
                i1.Fiyat = Convert.ToInt32(TextBox3.Text);
                i1.StokAdet = Convert.ToInt32(TextBox4.Text);
                i1.UretimTarihi = TextBox5.Text;
                i1.SonKullanmaTarihi = TextBox6.Text;
                i1.GenelBilgi = TextBox7.Text;
                if (i1.idILAC < 0 || i1.Fiyat <= 0 || i1.StokAdet <= 0)
                {
                    Response.Write("ID,Fiyat ve Stok Adeti Negatif Olamaz.");
                    return;

                }

                ECZADEPO.Ilac.Add(i1);
                ECZADEPO.SaveChanges();

            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }

        } //ILACLAR
        protected void Buton_Ekle2_Click2(object sender, EventArgs e)
        {
            try
            {

                Sube f1 = new Sube();
                f1.idSUBE = Convert.ToInt32(TextBox1.Text);
                f1.Ad = TextBox2.Text;
                f1.Adres = TextBox3.Text;
                f1.CalisanKisiSayisi = Convert.ToInt32(TextBox4.Text);
                if (f1.idSUBE <= 0 || f1.CalisanKisiSayisi <= 0)
                {
                    Response.Write("ID veya Çalışan Kişi Sayısı Negatif Olamaz.");
                    return;

                }
                ECZADEPO.Sube.Add(f1);
                ECZADEPO.SaveChanges();
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";
                Response.Write(mesaj);

            }

        } //SUBELER
        protected void Buton_Ekle3_Click3(object sender, EventArgs e)
        {
            try
            {
                Satis s1 = new Satis();

                s1.idSATIS = Convert.ToInt32(TextBox1.Text);
                s1.CalisanID = Convert.ToInt32(TextBox2.Text);
                s1.MusteriID = Convert.ToInt32(TextBox3.Text);
                s1.IlacID = Convert.ToInt32(TextBox4.Text);
                s1.Adet = Convert.ToInt32(TextBox5.Text);
                s1.Kazanc = Convert.ToInt32(TextBox6.Text);
                s1.Tarih = TextBox7.Text;
                ECZADEPO.Satis.Add(s1);
                ECZADEPO.SaveChanges();
                if (s1.idSATIS < 0 || s1.CalisanID < 0 || s1.MusteriID < 0 || s1.IlacID < 0 || s1.Adet < 0 || s1.Kazanc <= 0)
                {
                    Response.Write("Negatif Değer Girmeyiniz.");
                    return;
                }
        
            }
            catch
            {

                string mesaj = "TÜM ALANLARI DOLDURMAK ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //SATISLISTESI



        protected void Buton_Sil_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id3 = Convert.ToInt32(TextBox1.Text);

                var silinecek3 = ECZADEPO.Musteri.Where(w => w.idMUSTERI == id3).FirstOrDefault();
                if (id3 <= 0)
                {
                    Response.Write("ID negatif olamaz.");
                    return;
                }
                ECZADEPO.Musteri.Remove(silinecek3);
                ECZADEPO.SaveChanges();

              
            }
            catch
            {

                string mesaj = "ID GİRMENİZ ZORUNLUDUR.";

                Response.Write(mesaj);

            }

        }   //MUSTERİ
        protected void Buton_Sil0_Click0(object sender, EventArgs e)
        {

            try
            {
                int id1 = Convert.ToInt32(TextBox1.Text);

                

                if (id1 <= 0)
                {
                    Response.Write("ID Negatif Olamaz.");
                    return;

                }
                var silinecek1 = ECZADEPO.Calisan.Where(w => w.idCALISAN == id1).FirstOrDefault();
                ECZADEPO.Calisan.Remove(silinecek1);
                ECZADEPO.SaveChanges();

             
            }
            catch
            {

                string mesaj = "ID GİRMENİZ ZORUNLUDUR.";

                Response.Write(mesaj);

            }

        } //CALISAN
        protected void Buton_Sil1_Click1(object sender, EventArgs e)
        {
            try
            {
                int id2 = Convert.ToInt32(TextBox1.Text);
                if (id2 <= 0)
                {
                    Response.Write("ID Negatif Olamaz.");
                    return;

                }
                var silinecek2 = ECZADEPO.Ilac.Where(w => w.idILAC == id2).FirstOrDefault();

                ECZADEPO.Ilac.Remove(silinecek2);
                ECZADEPO.SaveChanges();

             
            }
            catch
            {

                string mesaj = "ID GİRMENİZ ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //ILACLAR
        protected void Buton_Sil2_Click2(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(TextBox1.Text);
                if (id <= 0)
                {
                    Response.Write("ID Negatif Olamaz.");
                    return;

                }

                var silinecek = ECZADEPO.Sube.Where(w => w.idSUBE == id).FirstOrDefault();

                ECZADEPO.Sube.Remove(silinecek);
                ECZADEPO.SaveChanges();

            }
            catch
            {

                string mesaj = "ID girmeniz zorunludur.";

                Response.Write(mesaj);

            }

        } //SUBELER
        protected void Buton_Sil3_Click3(object sender, EventArgs e)
        {
            try
            {
                int id4 = Convert.ToInt32(TextBox1.Text);
                if (id4 < 0)
                {
                    Response.Write("ID negatif olamaz.");
                    return;
                }
                var silinecek4 = ECZADEPO.Satis.Where(w => w.idSATIS == id4).FirstOrDefault();


                ECZADEPO.Satis.Remove(silinecek4);
                ECZADEPO.SaveChanges();

                
            }
            catch
            {

                string mesaj = "ID GİRMENİZ ZORUNLUDUR.";

                Response.Write(mesaj);

            }
        } //SATISLISTESI



        protected void Buton_Ara_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text.ToString()))
            {
                string aranan1 = Convert.ToString(TextBox1.Text);
                List<Musteri> sorgu1 = (from i in ECZADEPO.Musteri where i.idMUSTERI.ToString().ToUpper().Contains(aranan1.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu1.ToList();
                GridView1.DataBind();

            }
            else if (!string.IsNullOrEmpty(TextBox2.Text))
            {
                string aranan2 = TextBox2.Text;
                List<Musteri> sorgu2 = (from i in ECZADEPO.Musteri where i.Ad.ToUpper().Contains(aranan2.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu2.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox3.Text))
            {
                string aranan3 = TextBox3.Text;
                List<Musteri> sorgu3 = (from i in ECZADEPO.Musteri where i.Soyad.ToUpper().Contains(aranan3.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu3.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox4.Text))
            {
                string aranan4 = TextBox4.Text;
                List<Musteri> sorgu4 = (from i in ECZADEPO.Musteri where i.Telefon.ToUpper().Contains(aranan4.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu4.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox5.Text.ToString()))
            {
                string aranan5 = Convert.ToString(TextBox5.Text);
                List<Musteri> sorgu5 = (from i in ECZADEPO.Musteri where i.CalisanID.ToString().ToUpper().Contains(aranan5.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu5.ToList();
                GridView1.DataBind();
            }
        }   //MUSTERİ
        protected void Buton_Ara0_Click0(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text.ToString()))
            {
                string aranan1 = Convert.ToString(TextBox1.Text);
                List<Calisan> sorgu1 = (from i in ECZADEPO.Calisan where i.idCALISAN.ToString().ToUpper().Contains(aranan1.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu1.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox2.Text))
            {
                string aranan2 = TextBox2.Text;
                List<Calisan> sorgu2 = (from i in ECZADEPO.Calisan where i.Ad.ToUpper().Contains(aranan2.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu2.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox3.Text))
            {
                string aranan3 = TextBox3.Text;
                List<Calisan> sorgu3 = (from i in ECZADEPO.Calisan where i.Soyad.ToUpper().Contains(aranan3.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu3.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox4.Text))
            {
                string aranan4 = TextBox4.Text;
                List<Calisan> sorgu4 = (from i in ECZADEPO.Calisan where i.Telefon.ToUpper().Contains(aranan4.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu4.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox5.Text))
            {
                string aranan5 = TextBox5.Text;
                List<Calisan> sorgu5 = (from i in ECZADEPO.Calisan where i.Email.ToUpper().Contains(aranan5.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu5.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox6.Text))
            {
                string aranan6 = TextBox6.Text;
                List<Calisan> sorgu6 = (from i in ECZADEPO.Calisan where i.Görev.ToUpper().Contains(aranan6.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu6.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox7.Text))
            {
                string aranan7 = TextBox7.Text;
                List<Calisan> sorgu7 = (from i in ECZADEPO.Calisan where i.IseGirisTarihi.ToUpper().Contains(aranan7.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu7.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox8.Text.ToString()))
            {
                string aranan8 = Convert.ToString(TextBox8.Text);
                List<Calisan> sorgu8 = (from i in ECZADEPO.Calisan where i.Maas.ToString().ToUpper().Contains(aranan8.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu8.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox9.Text.ToString()))
            {
                string aranan9 = Convert.ToString(TextBox9.Text);
                List<Calisan> sorgu9 = (from i in ECZADEPO.Calisan where i.SubeID.ToString().ToUpper().Contains(aranan9.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu9.ToList();
                GridView1.DataBind();
            }
        } //CALISAN
        protected void Buton_Ara1_Click1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text.ToString()))
            {
                string aranan1 = Convert.ToString(TextBox1.Text);
                List<Ilac> sorgu1 = (from i in ECZADEPO.Ilac where i.idILAC.ToString().ToUpper().Contains(aranan1.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu1.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox2.Text))
            {
                string aranan2 = TextBox2.Text;
                List<Ilac> sorgu2 = (from i in ECZADEPO.Ilac where i.Ad.ToUpper().Contains(aranan2.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu2.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox3.Text.ToString()))
            {
                string aranan3 = Convert.ToString(TextBox3.Text);
                List<Ilac> sorgu3 = (from i in ECZADEPO.Ilac where i.Fiyat.ToString().ToUpper().Contains(aranan3.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu3.ToList();
                GridView1.DataBind(); 
            }
            else if (!string.IsNullOrEmpty(TextBox4.Text.ToString()))
            {
                string aranan4 = Convert.ToString(TextBox4.Text);
                List<Ilac> sorgu4 = (from i in ECZADEPO.Ilac where i.StokAdet.ToString().ToUpper().Contains(aranan4.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu4.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox5.Text))
            {
                string aranan5 = TextBox5.Text;
                List<Ilac> sorgu5 = (from i in ECZADEPO.Ilac where i.UretimTarihi.ToUpper().Contains(aranan5.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu5.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox6.Text))
            {
                string aranan6 = TextBox6.Text;
                List<Ilac> sorgu6 = (from i in ECZADEPO.Ilac where i.SonKullanmaTarihi.ToUpper().Contains(aranan6.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu6.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox7.Text))
            {
                string aranan7 = TextBox7.Text;
                List<Ilac> sorgu7 = (from i in ECZADEPO.Ilac where i.GenelBilgi.ToUpper().Contains(aranan7.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu7.ToList();
                GridView1.DataBind();
            }
        } //ILACLAR
        protected void Buton_Ara2_Click2(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TextBox1.Text.ToString()))
            {
                string aranan1 = Convert.ToString(TextBox1.Text);
                List<Sube> sorgu1 = (from i in ECZADEPO.Sube where i.idSUBE.ToString().ToUpper().Contains(aranan1.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu1.ToList();
                GridView1.DataBind();
            }
            else if(!string.IsNullOrEmpty(TextBox2.Text))
            {
                string aranan2 = TextBox2.Text;
                List<Sube> sorgu2 = (from i in ECZADEPO.Sube where i.Ad.ToUpper().Contains(aranan2.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu2.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox3.Text))
            {
                string aranan3 = TextBox3.Text;
                List<Sube> sorgu3 = (from i in ECZADEPO.Sube where i.Adres.ToUpper().Contains(aranan3.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu3.ToList();
                GridView1.DataBind();
            }
            if (!string.IsNullOrEmpty(TextBox4.Text.ToString()))
            {
                string aranan4 = Convert.ToString(TextBox4.Text);
                List<Sube> sorgu4 = (from i in ECZADEPO.Sube where i.CalisanKisiSayisi.ToString().ToUpper().Contains(aranan4.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu4.ToList();
                GridView1.DataBind();
            }

        } //SUBELER
        protected void Buton_Ara3_Click3(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TextBox1.Text.ToString()))
            {
                string aranan1 = Convert.ToString(TextBox1.Text);
                List<Satis> sorgu1 = (from i in ECZADEPO.Satis where i.idSATIS.ToString().ToUpper().Contains(aranan1.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu1.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox2.Text.ToString()))
            {
                string aranan2 = Convert.ToString(TextBox2.Text);
                List<Satis> sorgu2 = (from i in ECZADEPO.Satis where i.CalisanID.ToString().ToUpper().Contains(aranan2.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu2.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox3.Text.ToString()))
            {
                string aranan3 = Convert.ToString(TextBox3.Text);
                List<Satis> sorgu3 = (from i in ECZADEPO.Satis where i.MusteriID.ToString().ToUpper().Contains(aranan3.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu3.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox4.Text.ToString()))
            {
                string aranan4 = Convert.ToString(TextBox4.Text);
                List<Satis> sorgu4 = (from i in ECZADEPO.Satis where i.IlacID.ToString().ToUpper().Contains(aranan4.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu4.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox5.Text.ToString()))
            {
                string aranan5 = Convert.ToString(TextBox5.Text);
                List<Satis> sorgu5 = (from i in ECZADEPO.Satis where i.Adet.ToString().ToUpper().Contains(aranan5.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu5.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox6.Text.ToString()))
            {
                string aranan6 = Convert.ToString(TextBox6.Text);
                List<Satis> sorgu6 = (from i in ECZADEPO.Satis where i.Kazanc.ToString().ToUpper().Contains(aranan6.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu6.ToList();
                GridView1.DataBind();
            }
            else if (!string.IsNullOrEmpty(TextBox7.Text))
            {
                string aranan7 = TextBox7.Text;
                List<Satis> sorgu7 = (from i in ECZADEPO.Satis where i.Tarih.ToUpper().Contains(aranan7.ToLower()) select i).ToList();
                GridView1.DataSource = sorgu7.ToList();
                GridView1.DataBind();
            }
        } //SATISLISTESI



        protected void Buton_Anasayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}

