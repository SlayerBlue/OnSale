using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Resquest
{
    public class EmailRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
