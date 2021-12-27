using DestekApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DestekApp.data
{
    public class DestekAppDBContext : DbContext
    {
        public DestekAppDBContext(DbContextOptions<DestekAppDBContext> options) : base(options) { }


        public DbSet<Rol> Roller { get; set; }

        public DbSet<Kullanıcı> Kullanıcılar { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rol>().HasData(
                                                new Rol { RolID = 1, RolAdı = "UserCandidate" },
                                                new Rol { RolID = 2, RolAdı = "UserNormal" },
                                                new Rol { RolID = 3, RolAdı = "Admin" },
                                                new Rol { RolID = 4, RolAdı = "Supervisor" }

                                               );

            modelBuilder.Entity<Kullanıcı>().HasData(
new Kullanıcı { KullanıcıID = 1, Eposta = "gizem@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 2, Eposta = "ali@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 3, Eposta = "mahmut@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 4, Eposta = "mansur @hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 5, Eposta = "gamze@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 6, Eposta = "miraç@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 7, Eposta = "yücel@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 8, Eposta = "kubilay@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 9, Eposta = "hayati@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 10, Eposta = "bedriye müge@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 11, Eposta = "birsen@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 12, Eposta = "serdal@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 13, Eposta = "bünyamin@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 14, Eposta = "özgür@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 15, Eposta = "ferdi@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 16, Eposta = "reyhan@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 17, Eposta = "ilhan@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 18, Eposta = "gülşah@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 19, Eposta = "nalan@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 20, Eposta = "semih@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 21, Eposta = "ergün@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 22, Eposta = "fatih@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 23, Eposta = "şenay@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 24, Eposta = "serkan@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 25, Eposta = "emre@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 26, Eposta = "peker@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 27, Eposta = "irazca@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 28, Eposta = "hatice@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 29, Eposta = "bariş@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 30, Eposta = "rezan@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 31, Eposta = "fatih@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 32, Eposta = "fuat@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 33, Eposta = "gökhan@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 34, Eposta = "orhan@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 35, Eposta = "mehmet@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 36, Eposta = "evren@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 37, Eposta = "oktay@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 38, Eposta = "harun@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 39, Eposta = "yavuz@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 40, Eposta = "pinar@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 41, Eposta = "mehmet@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 42, Eposta = "umut@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 43, Eposta = "mesude@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 44, Eposta = "seko@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 45, Eposta = "yunus@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 46, Eposta = "eyyup sabri@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 47, Eposta = "umut@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 48, Eposta = "cengiz@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 49, Eposta = "ufuk@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 50, Eposta = "ahmet ali@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 51, Eposta = "mediha@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 },
new Kullanıcı { KullanıcıID = 52, Eposta = "hasan@outlook.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 4 },
new Kullanıcı { KullanıcıID = 53, Eposta = "kamil@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 54, Eposta = "nebi@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 55, Eposta = "özcan@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 56, Eposta = "ilayda@icloud.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 3 },
new Kullanıcı { KullanıcıID = 57, Eposta = "ceren@hotmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 2 },
new Kullanıcı { KullanıcıID = 58, Eposta = "serkan@gmail.com", Şifre = "123456", ŞifreTekrarı = "123456", RolID = 1 }

                                              );



        }



    }
}
