using System.ComponentModel.DataAnnotations;

namespace jobSearch.ViewModel
{
    public class LoginVM
    {
        [Display(Name = "Ваш E-Mail")]
        [Required(ErrorMessage = "Это поле обязательно")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
