using MagazaOtomasyon.DataAccess.Concrete.EntityFramework.Mappings;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class MagazaOtomasyonContext : DbContext
    {
        public MagazaOtomasyonContext():base("DenemeOtomasyon1")
        {
            Database.SetInitializer(new ModelInitializer());
        }

        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<FaturaBilgi> FaturaBilgiler { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylar { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<FirmaHareket> FirmaHareketler { get; set; }
        public DbSet<Gider> Giderler { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriHareket> MusteriHareketler { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BankaMap());
            modelBuilder.Configurations.Add(new FaturaBilgiMap());
            modelBuilder.Configurations.Add(new FaturaDetayMap());
            modelBuilder.Configurations.Add(new FirmaMap());
            modelBuilder.Configurations.Add(new GiderMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new NotMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new UrunMap());
        }
    }
}
