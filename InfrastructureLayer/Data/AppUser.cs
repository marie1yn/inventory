using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        [ForeignKey(nameof(ProgramId))]
        public int? ProgramId { get; set; }
        //public virtual DomainLayer.Models.Program Programs { get; set; }
    }
}
