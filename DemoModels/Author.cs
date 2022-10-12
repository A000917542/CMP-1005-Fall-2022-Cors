using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoModels
{
    public class Author
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;
        
        [Required]
        public string LastName { get; set; } = String.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;
    }
}
