using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace job_tracker.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Notes { get; set; }

        public bool Applied { get; set; } = false;

        public bool Interviewed { get; set; } = false;

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Required]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}