using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DestekApp.Models
{
    public class Rol

    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RolID { get; set; }
        [Required, StringLength(20, MinimumLength = 3, ErrorMessage = "Rol Adı en az 3 en fazla 20 karakter olabilie"), Display(Name = "Rol Adı")]
        public string RolAdı { get; set; }



    }
}
