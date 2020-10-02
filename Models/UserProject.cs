using System.Collections.Generic;

namespace Padronize.Models
{
    public class UserProject
    {
        public int UserId { get; set; }
        public virtual User user { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }


    }
}