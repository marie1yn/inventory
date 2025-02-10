using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace inventory.DATA
{
    public class AppUser: IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        [ForeignKey(nameof(ProgramId))]
        public int? ProgramId { get; set; }
    }
}
