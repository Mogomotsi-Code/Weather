using System;
using System.Collections.Generic;

namespace Weather.Models.DTOs
{
    public class ForeCast
    {
        public string Dt_txt { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public string Dt { get; set; }
        public Sys Sys { get; set; }
    }
}
