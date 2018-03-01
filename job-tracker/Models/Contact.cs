using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace job_tracker.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Notes { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}