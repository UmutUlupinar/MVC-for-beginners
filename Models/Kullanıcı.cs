using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DestekApp.Models
{
    public class Kullanıcı
    {
        [Key]
        public int KullanıcıID { get; set; }

        [Required(ErrorMessage = "Eposta gerekli."), StringLength(50, MinimumLength = 6, ErrorMessage = "E-posta en az 6 en fazla 50 karakter olabilir."), DataType(DataType.EmailAddress, ErrorMessage = "Geçersiz E-posta")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Şifre gerekli."), StringLength(20, MinimumLength = 6, ErrorMessage = "Şifre en az 6 en fazla 20 karakter olabilir."), DataType(DataType.Password)]
        public string Şifre { get; set; }

        [NotMapped, Display(Name = "Şifre Tekrarı"), DataType(DataType.Password), Compare("Şifre", ErrorMessage = "Şifre ve tekrarı uyuşmuyor.")]
        public string ŞifreTekrarı { get; set; }

        [Required(ErrorMessage = "ROL gerekli."), Display(Name = "Rol")]
        public int RolID { get; set; }


        public Rol Rol { get; set; } // navigasyon için gerekli



    }
}
