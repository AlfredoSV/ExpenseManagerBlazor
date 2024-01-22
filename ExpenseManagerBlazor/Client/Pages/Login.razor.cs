using System.ComponentModel.DataAnnotations;

namespace ExpenseManagerBlazor.Client.Pages
{
    public partial class Login
    {

        private User user = new();
        protected override Task OnInitializedAsync()
        {

            return base.OnInitializedAsync();
        }

        protected void Success()
        {


        }

    }

    class User
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [EmailAddress(ErrorMessage = "El correo no es correcto")]
        public string Email { get; set; }

    }
}
