using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company
    {
        [Column ("Company")]
        public Guid Id { get; set; }
        [Required (ErrorMessage ="Company name is required field")]
        [MaxLength(70, ErrorMessage ="Maximum lenght for the Name is 60 characters.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Company address is required field")]
        [MaxLength(70, ErrorMessage = "Maximum length for the Address is 60 characters.")]
        public string? Address { get; set; }
        public string? Country { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
