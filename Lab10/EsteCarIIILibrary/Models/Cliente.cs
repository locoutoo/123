using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EstCarIIILibrary.Models
{
    public class Cliente : IdentityUser
    {
        [Required]
        public string Nome { get; set; }
    }
}
