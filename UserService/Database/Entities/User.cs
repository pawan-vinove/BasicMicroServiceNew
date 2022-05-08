using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
    public string Name { get; set; }
    public string Address { get; set; }
    
    [Required]
    [MinLength(10)]
    public string Contact { get; set; }
    
    }
}