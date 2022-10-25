using System.ComponentModel.DataAnnotations;

namespace Project.COREUI.ViemClasses
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lutfen isim degeri girin")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lutfen soyisim degeri girin")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lutfen kullanıcı adı degeri girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lutfen mail degeri girin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lutfen sifre degeri girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lutfen sifreyi tekrar girin")]
        [Compare("Password", ErrorMessage ="Sifreler eslesmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
