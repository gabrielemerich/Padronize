using System.Collections.Generic;
using Newtonsoft.Json;

namespace Padronize.Models
{
    public class Standart
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string code_example { get; set; }
        public virtual IEnumerable<Image> images { get; set; }
        public virtual Application application { get; set; }

    }
}