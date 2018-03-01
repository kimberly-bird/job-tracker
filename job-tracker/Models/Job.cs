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

    }
}