using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo {0} está vazio, Favor Informe o seu Usuário")]
        [Display(Name ="Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo {0} está vazio, Favor Informe a sua senha")]
        [DataType(DataType.Password)]
        [Display(Name ="Senha")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
