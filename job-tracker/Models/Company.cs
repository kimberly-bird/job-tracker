﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace job_tracker.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}