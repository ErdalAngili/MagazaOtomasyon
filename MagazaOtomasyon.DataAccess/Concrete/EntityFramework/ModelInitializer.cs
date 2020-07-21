using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class ModelInitializer : CreateDatabaseIfNotExists<MagazaOtomasyonContext>
    {
            protected override void Seed(MagazaOtomasyonContext context)
            {
                IList<Il> Iller = new List<Il>();
                Iller.Add(new Il() { Sehir = "Adana" });
                Iller.Add(new Il() { Sehir = "Adıyaman" });
                Iller.Add(new Il() { Sehir = "Afyonkarahisar" });
                Iller.Add(new Il() { Sehir = "Ağrı" });
                Iller.Add(new Il() { Sehir = "Amasya" });
                Iller.Add(new Il() { Sehir = "Ankara" });
                Iller.Add(new Il() { Sehir = "Antalya" });
                Iller.Add(new Il() { Sehir = "Artvin" });
                Iller.Add(new Il() { Sehir = "Aydın" });
                Iller.Add(new Il() { Sehir = "Balıkesir" });
                Iller.Add(new Il() { Sehir = "Bilecek" });
                Iller.Add(new Il() { Sehir = "Bingöl" });
                Iller.Add(new Il() { Sehir = "Bitlis" });
                Iller.Add(new Il() { Sehir = "Bolu" });
                Iller.Add(new Il() { Sehir = "Burdur" });
                Iller.Add(new Il() { Sehir = "Bursa" });
                Iller.Add(new Il() { Sehir = "Çanakkale" });
                Iller.Add(new Il() { Sehir = "Çankırı" });
                Iller.Add(new Il() { Sehir = "Çorum" });
                Iller.Add(new Il() { Sehir = "Denizli" });
                Iller.Add(new Il() { Sehir = "Diyarbakır" });
                Iller.Add(new Il() { Sehir = "Edirne" });
                Iller.Add(new Il() { Sehir = "Elazığ" });
                Iller.Add(new Il() { Sehir = "Erzincan" });
                Iller.Add(new Il() { Sehir = "Erzurum" });
                Iller.Add(new Il() { Sehir = "Eskişehir" });
                Iller.Add(new Il() { Sehir = "Gaziantep" });
                Iller.Add(new Il() { Sehir = "Giresun" });
                Iller.Add(new Il() { Sehir = "Gümüşhane" });
                Iller.Add(new Il() { Sehir = "Hakkari" });
                Iller.Add(new Il() { Sehir = "Hatay" });
                Iller.Add(new Il() { Sehir = "Isparta" });
                Iller.Add(new Il() { Sehir = "Mersin" });
                Iller.Add(new Il() { Sehir = "İstanbul" });
                Iller.Add(new Il() { Sehir = "İzmir" });
                Iller.Add(new Il() { Sehir = "Kars" });
                Iller.Add(new Il() { Sehir = "Kastamonu" });
                Iller.Add(new Il() { Sehir = "Kayseri" });
                Iller.Add(new Il() { Sehir = "Kırklareli" });
                Iller.Add(new Il() { Sehir = "Kırşehir" });
                Iller.Add(new Il() { Sehir = "Kocaeli" });
                Iller.Add(new Il() { Sehir = "Konya" });
                Iller.Add(new Il() { Sehir = "Kütahya" });
                Iller.Add(new Il() { Sehir = "Malatya" });
                Iller.Add(new Il() { Sehir = "Manisa" });
                Iller.Add(new Il() { Sehir = "Kahramanmaraş" });
                Iller.Add(new Il() { Sehir = "Mardin" });
                Iller.Add(new Il() { Sehir = "Muğla" });
                Iller.Add(new Il() { Sehir = "Muş" });
                Iller.Add(new Il() { Sehir = "Nevşehir" });
                Iller.Add(new Il() { Sehir = "Niğde" });
                Iller.Add(new Il() { Sehir = "Ordu" });
                Iller.Add(new Il() { Sehir = "Rize" });
                Iller.Add(new Il() { Sehir = "Sakarya" });
                Iller.Add(new Il() { Sehir = "Samsun" });
                Iller.Add(new Il() { Sehir = "Siirt" });
                Iller.Add(new Il() { Sehir = "Sinop" });
                Iller.Add(new Il() { Sehir = "Sivas" });
                Iller.Add(new Il() { Sehir = "Tekirdağ" });
                Iller.Add(new Il() { Sehir = "Tokat" });
                Iller.Add(new Il() { Sehir = "Trabzon" });
                Iller.Add(new Il() { Sehir = "Tunceli" });
                Iller.Add(new Il() { Sehir = "Şanlıurfa" });
                Iller.Add(new Il() { Sehir = "Uşak" });
                Iller.Add(new Il() { Sehir = "Van" });
                Iller.Add(new Il() { Sehir = "Yozgat" });
                Iller.Add(new Il() { Sehir = "Zonguldak" });
                Iller.Add(new Il() { Sehir = "Aksaray" });
                Iller.Add(new Il() { Sehir = "Bayburt" });
                Iller.Add(new Il() { Sehir = "Karaman" });
                Iller.Add(new Il() { Sehir = "Kırıkkale" });
                Iller.Add(new Il() { Sehir = "Batman" });
                Iller.Add(new Il() { Sehir = "Şırnak" });
                Iller.Add(new Il() { Sehir = "Bartın" });
                Iller.Add(new Il() { Sehir = "Ardahan" });
                Iller.Add(new Il() { Sehir = "Iğdır" });
                Iller.Add(new Il() { Sehir = "Yalova" });
                Iller.Add(new Il() { Sehir = "Karabük" });
                Iller.Add(new Il() { Sehir = "Kilis" });
                Iller.Add(new Il() { Sehir = "Osmaniye" });
                Iller.Add(new Il() { Sehir = "Düzce" });

                context.Iller.AddRange(Iller);
                context.SaveChanges();

                IList<Ilce> Ilceler = new List<Ilce>();
                Ilceler.Add(new Ilce() { Ilceler = "Seyhan", IlId = 1 });
                Ilceler.Add(new Ilce() { Ilceler = "Ceyhan", IlId = 1 });
                Ilceler.Add(new Ilce() { Ilceler = "Çukurova", IlId = 1 });
                Ilceler.Add(new Ilce() { Ilceler = "Yüreğir", IlId = 1 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 2 });
                Ilceler.Add(new Ilce() { Ilceler = "Kahta", IlId = 2 });
                Ilceler.Add(new Ilce() { Ilceler = "Besni", IlId = 2 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 3 });
                Ilceler.Add(new Ilce() { Ilceler = "Sandıklı", IlId = 3 });
                Ilceler.Add(new Ilce() { Ilceler = "Dinar", IlId = 3 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 4 });
                Ilceler.Add(new Ilce() { Ilceler = "Patnos", IlId = 4 });
                Ilceler.Add(new Ilce() { Ilceler = "Doğubayazıt", IlId = 4 });
                Ilceler.Add(new Ilce() { Ilceler = "Diyadin", IlId = 4 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 5 });
                Ilceler.Add(new Ilce() { Ilceler = "Ortaköy", IlId = 5 });

                Ilceler.Add(new Ilce() { Ilceler = "Çankaya", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Keçiören", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Yenimahalle", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Mamak", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Etimesgut", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Sincan", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Altındağ", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Pursaklar", IlId = 6 });
                Ilceler.Add(new Ilce() { Ilceler = "Gölbaşı", IlId = 6 });

                Ilceler.Add(new Ilce() { Ilceler = "Kepez", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Muratpaşa", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Alanya", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Manavgat", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Konyaaltı", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Serik", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Aksu", IlId = 7 });
                Ilceler.Add(new Ilce() { Ilceler = "Kumluca", IlId = 7 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 8 });
                Ilceler.Add(new Ilce() { Ilceler = "Hopa", IlId = 8 });

                Ilceler.Add(new Ilce() { Ilceler = "Efeler", IlId = 9 });
                Ilceler.Add(new Ilce() { Ilceler = "Nazilli", IlId = 9 });
                Ilceler.Add(new Ilce() { Ilceler = "Söke", IlId = 9 });
                Ilceler.Add(new Ilce() { Ilceler = "Kuşadası", IlId = 9 });
                Ilceler.Add(new Ilce() { Ilceler = "Didim", IlId = 9 });

                Ilceler.Add(new Ilce() { Ilceler = "Karesi", IlId = 10 });
                Ilceler.Add(new Ilce() { Ilceler = "Altıeylül", IlId = 10 });
                Ilceler.Add(new Ilce() { Ilceler = "Bandırma", IlId = 10 });
                Ilceler.Add(new Ilce() { Ilceler = "Edremit", IlId = 10 });
                Ilceler.Add(new Ilce() { Ilceler = "Gönen", IlId = 10 });
                Ilceler.Add(new Ilce() { Ilceler = "Ayvalık", IlId = 10 });
                Ilceler.Add(new Ilce() { Ilceler = "Burhaniye", IlId = 10 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 11 });
                Ilceler.Add(new Ilce() { Ilceler = "Bozüyük", IlId = 11 });
                Ilceler.Add(new Ilce() { Ilceler = "Osmaneli", IlId = 11 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 12 });
                Ilceler.Add(new Ilce() { Ilceler = "Genç", IlId = 12 });

                Ilceler.Add(new Ilce() { Ilceler = "Tatvan", IlId = 13 });
                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 13 });
                Ilceler.Add(new Ilce() { Ilceler = "Güroymak", IlId = 13 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 14 });
                Ilceler.Add(new Ilce() { Ilceler = "Gerede", IlId = 14 });
                Ilceler.Add(new Ilce() { Ilceler = "Mudurnu", IlId = 14 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 15 });
                Ilceler.Add(new Ilce() { Ilceler = "Bucak", IlId = 15 });

                Ilceler.Add(new Ilce() { Ilceler = "Osmangazi", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "Yıldırım", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "Nilüfer", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "İnegöl", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "Gemlik", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "Mustafakemalpaşa", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "Mudanya", IlId = 16 });
                Ilceler.Add(new Ilce() { Ilceler = "Gürsu", IlId = 16 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 17 });
                Ilceler.Add(new Ilce() { Ilceler = "Biga", IlId = 17 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 18 });
                Ilceler.Add(new Ilce() { Ilceler = "Çerkeş", IlId = 18 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 19 });
                Ilceler.Add(new Ilce() { Ilceler = "Sungurlu", IlId = 19 });

                Ilceler.Add(new Ilce() { Ilceler = "Pamukkale", IlId = 20 });
                Ilceler.Add(new Ilce() { Ilceler = "Merkezefendi", IlId = 20 });
                Ilceler.Add(new Ilce() { Ilceler = "Çivril", IlId = 20 });
                Ilceler.Add(new Ilce() { Ilceler = "Acıpayam", IlId = 20 });

                Ilceler.Add(new Ilce() { Ilceler = "Bağlar", IlId = 21 });
                Ilceler.Add(new Ilce() { Ilceler = "Kayapınar", IlId = 21 });
                Ilceler.Add(new Ilce() { Ilceler = "Yenişehir", IlId = 21 });
                Ilceler.Add(new Ilce() { Ilceler = "Ergani", IlId = 21 });
                Ilceler.Add(new Ilce() { Ilceler = "Bismil", IlId = 21 });
                Ilceler.Add(new Ilce() { Ilceler = "Sur", IlId = 21 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 22 });
                Ilceler.Add(new Ilce() { Ilceler = "Keşan", IlId = 22 });
                Ilceler.Add(new Ilce() { Ilceler = "Uzunköprü", IlId = 22 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 23 });
                Ilceler.Add(new Ilce() { Ilceler = "Kovancılar", IlId = 23 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 24 });
                Ilceler.Add(new Ilce() { Ilceler = "Tercan", IlId = 24 });
                Ilceler.Add(new Ilce() { Ilceler = "Üzümlü", IlId = 24 });

                Ilceler.Add(new Ilce() { Ilceler = "Yakutiye", IlId = 25 });
                Ilceler.Add(new Ilce() { Ilceler = "Palandöken", IlId = 25 });
                Ilceler.Add(new Ilce() { Ilceler = "Aziziye", IlId = 25 });
                Ilceler.Add(new Ilce() { Ilceler = "Horasan", IlId = 25 });
                Ilceler.Add(new Ilce() { Ilceler = "Oltu", IlId = 25 });

                Ilceler.Add(new Ilce() { Ilceler = "Odunpazarı", IlId = 26 });
                Ilceler.Add(new Ilce() { Ilceler = "Tepebaşı", IlId = 26 });
                Ilceler.Add(new Ilce() { Ilceler = "Sivrihisar", IlId = 26 });

                Ilceler.Add(new Ilce() { Ilceler = "Şahinbey", IlId = 27 });
                Ilceler.Add(new Ilce() { Ilceler = "Şehitkamil", IlId = 27 });
                Ilceler.Add(new Ilce() { Ilceler = "Nizip", IlId = 27 });
                Ilceler.Add(new Ilce() { Ilceler = "İslahiye", IlId = 27 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 28 });
                Ilceler.Add(new Ilce() { Ilceler = "Bulancak", IlId = 28 });
                Ilceler.Add(new Ilce() { Ilceler = "Espiye", IlId = 28 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 29 });
                Ilceler.Add(new Ilce() { Ilceler = "Kelkit", IlId = 29 });

                Ilceler.Add(new Ilce() { Ilceler = "Yüksekova", IlId = 30 });
                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 30 });
                Ilceler.Add(new Ilce() { Ilceler = "Şemdinli", IlId = 30 });

                Ilceler.Add(new Ilce() { Ilceler = "Antakya", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "İskenderun", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Defne", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Dörtyol", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Samandağ", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Kırıkhan", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Reyhanlı", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Arsuz", IlId = 31 });
                Ilceler.Add(new Ilce() { Ilceler = "Altınözü", IlId = 31 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 32 });
                Ilceler.Add(new Ilce() { Ilceler = "Yalvaç", IlId = 32 });
                Ilceler.Add(new Ilce() { Ilceler = "Eğirdir", IlId = 32 });

                Ilceler.Add(new Ilce() { Ilceler = "Tarsus", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Toroslar", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Yenişehir", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Akdeniz", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Mezitli", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Erdemli", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Silifke", IlId = 33 });
                Ilceler.Add(new Ilce() { Ilceler = "Anamur", IlId = 33 });

                Ilceler.Add(new Ilce() { Ilceler = "Esenyurt", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Küçükçekmece", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Bağcılar", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Pendik", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Pendik", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Bahçelievler", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Sultangazi", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Üsküdar", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Maltepe", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Gaziosmanpaşa", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Kadıköy", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Kartal", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Başakşehir", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Esenler", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Avcılar", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Kağıthane", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Fatih", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Sancaktepe", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Ataşehir", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Eyüpsultan", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Beylikdüzü", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Sarıyer", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Sultanbeyli", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Zeytinburnu", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Güngören", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Arnavutköy", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Şişli", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Bayrampaşa", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Tuzla", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Çekmeköy", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Büyükçekmece", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Beykoz", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Beyoğlu", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Bakırköy", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Silivri", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Beşiktaş", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Çatalca", IlId = 34 });
                Ilceler.Add(new Ilce() { Ilceler = "Şile", IlId = 34 });

                Ilceler.Add(new Ilce() { Ilceler = "Buca", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Karabağlar", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Bornova", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Konak", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Karşıyaka", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Bayraklı", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Çiğli", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Torbalı", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Menemen", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Gaziemir", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Ödemiş", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Kemalpaşa", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Bergama", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Menderes", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Aliağa", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Tire", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Balçova", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Urla", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Narlıdere", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Seferihisar", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Çeşme", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Kiraz", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Dikili", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Bayındır", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Selçuk", IlId = 35 });
                Ilceler.Add(new Ilce() { Ilceler = "Güzelbahçe", IlId = 35 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 36 });
                Ilceler.Add(new Ilce() { Ilceler = "Kağızman", IlId = 36 });
                Ilceler.Add(new Ilce() { Ilceler = "Sarıkamış", IlId = 36 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 37 });
                Ilceler.Add(new Ilce() { Ilceler = "Tosya", IlId = 37 });
                Ilceler.Add(new Ilce() { Ilceler = "Taşköprü", IlId = 37 });

                Ilceler.Add(new Ilce() { Ilceler = "Melikgazi", IlId = 38 });
                Ilceler.Add(new Ilce() { Ilceler = "Kocasinan", IlId = 38 });
                Ilceler.Add(new Ilce() { Ilceler = "Talas", IlId = 38 });
                Ilceler.Add(new Ilce() { Ilceler = "Develi", IlId = 38 });
                Ilceler.Add(new Ilce() { Ilceler = "Yahyalı", IlId = 38 });

                Ilceler.Add(new Ilce() { Ilceler = "Lüleburgaz", IlId = 39 });
                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 39 });
                Ilceler.Add(new Ilce() { Ilceler = "Babaeski", IlId = 39 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 40 });
                Ilceler.Add(new Ilce() { Ilceler = "Kaman", IlId = 40 });

                Ilceler.Add(new Ilce() { Ilceler = "Gebze", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "İzmit", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Darıca", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Körfez", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Gölcük", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Derince", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Çayırova", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Kartepe", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Başiskele", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Karamürsel", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Kandıra", IlId = 41 });
                Ilceler.Add(new Ilce() { Ilceler = "Dilovası", IlId = 41 });

                Ilceler.Add(new Ilce() { Ilceler = "Selçuklu", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Meram", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Karatay", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Ereğli", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Akşehir", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Beyşehir", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Çumra", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Seydişehir", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Ilgın", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Cihanbeyli", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Kulu", IlId = 42 });
                Ilceler.Add(new Ilce() { Ilceler = "Karapınar", IlId = 42 });

                Ilceler.Add(new Ilce() { Ilceler = "Merkez", IlId = 43 });
                Ilceler.Add(new Ilce() { Ilceler = "Tavşanlı", IlId = 43 });
                Ilceler.Add(new Ilce() { Ilceler = "Simav", IlId = 43 });
                Ilceler.Add(new Ilce() { Ilceler = "Gediz", IlId = 43 });

                Ilceler.Add(new Ilce() { Ilceler = "Yeşilyurt", IlId = 44 });
                Ilceler.Add(new Ilce() { Ilceler = "Battalgazi", IlId = 44 });
                Ilceler.Add(new Ilce() { Ilceler = "Doğanşehir", IlId = 44 });

                Ilceler.Add(new Ilce() { Ilceler = "Yunusemre", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Akhisar", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Şehzadeler", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Turgutlu", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Salihli", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Soma", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Alaşehir", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Saruhanlı", IlId = 45 });
                Ilceler.Add(new Ilce() { Ilceler = "Kula", IlId = 45 });

                Ilceler.Add(new Ilce() { Ilceler = "Onikişubat", IlId = 46 });
                Ilceler.Add(new Ilce() { Ilceler = "Dulkadiroğlu", IlId = 46 });
                Ilceler.Add(new Ilce() { Ilceler = "Elbistan", IlId = 46 });
                Ilceler.Add(new Ilce() { Ilceler = "Afşin", IlId = 46 });
                Ilceler.Add(new Ilce() { Ilceler = "Türkoğlu", IlId = 46 });
                Ilceler.Add(new Ilce() { Ilceler = "Pazarcık", IlId = 46 });
                Ilceler.Add(new Ilce() { Ilceler = "Göksun", IlId = 46 });

                context.Ilceler.AddRange(Ilceler);
                context.SaveChanges();
                base.Seed(context);
            }
    }
}
