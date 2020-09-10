using Microsoft.EntityFrameworkCore;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Context
{
    public class MasterContext : DbContext
    {
        public MasterContext()
        {

        }
        public MasterContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<RentaCarModel> RentaCarModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }

        //burada projenin bağlanacağı veri tabanı teknolojisi(mysql) ve bağlantı adresi(connectionstring) tanımlandı.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;username=root;password=root;database=rentacar");
        }


        // ilişkilerin ve model ayarlarının tanımlandığı yer.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //burada bool olan property i short yaparak korunum sağladık.
            modelBuilder.Entity<UserModel>().Property(x => x.isSuperAdmin).HasConversion<short>();



            // burada user ile  bire bir ilişki tanımlandı.
            modelBuilder.Entity<RentaCarModel>()
                .HasOne(x => x.UserModel)
                .WithOne(y =>y.RentaCarModel)
                .HasForeignKey<RentaCarModel>(z => z.UserId);


            // burada carmodel bire bir ilişki tanımlandı.
            modelBuilder.Entity<RentaCarModel>()
                .HasOne(x => x.CarModel)
                .WithOne(y => y.RentaCarModel)
                .HasForeignKey<RentaCarModel>(x => x.CarId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
