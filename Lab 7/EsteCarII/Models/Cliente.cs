using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EsteCarII.Models
{
    public class Cliente : IdentityUser
    {
        [Required]
        public string Nome { get; set; }
    }
}
