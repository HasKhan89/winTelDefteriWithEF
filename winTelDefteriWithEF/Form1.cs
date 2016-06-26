using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTelDefteriWithEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TelefonDBEntities db = new TelefonDBEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriYukle();
        }

        private void KisileriYukle()
        {
            List<Kisi> kisiler = (from k in db.Kisi
                                  orderby k.Ad, k.Soyad
                                  select k).ToList();

            lstKisiler.DataSource = kisiler;
        }

        private void AdreslerYenidenYukle()
        {
            // Kişi listesinden seçimi kaldırıp geri koyuyorum ki tekrardan verileri çeksin. Listbox adresler güncellensin.
            int index = lstKisiler.SelectedIndex;
            lstKisiler.SelectedIndex = -1;
            lstKisiler.SelectedIndex = index;
        }


        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kişi seçilmiş ise..
            if (lstKisiler.SelectedIndex > -1)
            {
                // Listbox'dan seçilen item 'a ait nesne elde edilir.
                Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

                if (secilenKisi != null)
                {
                    // lstAdresler listesi için veri kaynağı seçilen kişinin adres listesidir.
                    lstAdresler.DataSource = secilenKisi.Adres.ToList();

                    txtKisiAd.Text = secilenKisi.Ad;
                    txtKisiSoyad.Text = secilenKisi.Soyad;
                    txtKisiTel.Text = secilenKisi.Tel;
                }

            }
            else
            {
                txtKisiAd.Clear();
                txtKisiSoyad.Clear();
                txtKisiTel.Clear();
            }
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi()
            {
                Ad = txtKisiAd.Text,
                Soyad = txtKisiSoyad.Text,
                Tel = txtKisiTel.Text
            };

            db.Kisi.Add(kisi);
            db.SaveChanges();

            KisileriYukle();
        }

        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {
            //Action<Kisi> kod = new Action<Kisi>(KaydetKodu);
            //KisiKaydetSil(kod);

            KisiKaydetSil(new Action<Kisi>(secilenKisi =>
            {
                // Seçilen kişinin tüm adresleri silinir.
                secilenKisi.Adres.ToList().ForEach(x => db.Adres.Remove(x));

                // Seçilen kişi silinir.
                db.Kisi.Remove(secilenKisi);

                db.SaveChanges();

                KisileriYukle();
            }));
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            Action<Kisi> kod = new Action<Kisi>(SilmeKodu);
            KisiKaydetSil(kod);
        }


        private void SilmeKodu(Kisi secilenKisi)
        {
            // Seçilen kişinin tüm adresleri silinir.
            secilenKisi.Adres.ToList().ForEach(x => db.Adres.Remove(x));

            // Seçilen kişi silinir.
            db.Kisi.Remove(secilenKisi);

            db.SaveChanges();

            KisileriYukle();
        }
        private void KaydetKodu(Kisi secilenKisi)
        {
            secilenKisi.Ad = txtKisiAd.Text;
            secilenKisi.Soyad = txtKisiSoyad.Text;
            secilenKisi.Tel = txtKisiTel.Text;

            db.SaveChanges();

            KisileriYukle();
        }


        private void KisiKaydetSil(Action<Kisi> kod)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

                if (secilenKisi != null)
                {
                    // Gelen metodun çalışması gerekli..
                    kod(secilenKisi);
                }
            }
        }




        private void btnAdresEkle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

                if (secilenKisi != null)
                {
                    Adres yeniAdres = new Adres()
                    {
                        AdresTanim = txtAdresTanim.Text,
                        Kisi = secilenKisi  // Yeni adres nesnesinin sahip oldugu kişi nesnesi.
                    };

                    //secilenKisi.Adres.Add(yeniAdres);

                    db.Adres.Add(yeniAdres);
                    db.SaveChanges();

                    AdreslerYenidenYukle();
                }
            }
        }

        private void btnAdresKaydet_Click(object sender, EventArgs e)
        {
            if (lstAdresler.SelectedIndex > -1)
            {
                Adres secilenAdres = lstAdresler.SelectedItem as Adres;

                if (secilenAdres != null)
                {
                    secilenAdres.AdresTanim = txtAdresTanim.Text;

                    db.SaveChanges();

                    AdreslerYenidenYukle();
                }
            }
        }

        private void lstAdresler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAdresler.SelectedIndex > -1)
            {
                Adres secilenAdres = lstAdresler.SelectedItem as Adres;

                if (secilenAdres != null)
                {
                    txtAdresTanim.Text = secilenAdres.AdresTanim;
                }
            }
            else
            {
                txtAdresTanim.Clear();
            }
        }

        private void btnAdresSil_Click(object sender, EventArgs e)
        {
            if (lstAdresler.SelectedIndex > -1)
            {
                Adres secilenAdres = lstAdresler.SelectedItem as Adres;

                if (secilenAdres != null)
                {
                    db.Adres.Remove(secilenAdres);

                    db.SaveChanges();

                    AdreslerYenidenYukle();
                }
            }
        }
    }
}
