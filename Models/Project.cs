using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Padronize.Models
{
    public class Project
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public virtual IEnumerable<Application> applications { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public virtual List<UserProject> UserProjects { get; set; }

    }
}