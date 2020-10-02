using System.Collections.Generic;

namespace Padronize.Models
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public virtual List<UserProject> UserProjects { get; set; }
    }
}