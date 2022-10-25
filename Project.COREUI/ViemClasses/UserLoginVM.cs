using System.ComponentModel.DataAnnotations;

namespace Project.COREUI.ViemClasses
{
    public class UserLoginVM
    {
        [Required(ErrorMessage = "Lutfen kullanıcı adınız giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen sifrenizi giriniz")]

        public string Password { get; set; }
    }
}
