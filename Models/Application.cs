using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Padronize.Models
{
    public class Application
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public virtual Project project { get; set; }
        public int projectid { get; set; }
        public virtual IEnumerable<Standart> Standarts { get; set; }


    }
}