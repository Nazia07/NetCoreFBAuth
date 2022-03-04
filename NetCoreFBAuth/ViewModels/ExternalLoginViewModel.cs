using System.ComponentModel.DataAnnotations;

namespace NetCoreFBAuth.ViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}