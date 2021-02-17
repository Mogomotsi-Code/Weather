using System;
using System.Collections.Generic;

namespace Weather.Models.DTOs
{
    public class ForecastResponse
    {
        public List<ForeCast> List { get; set; }
        public string Message { get; set; }
        public int Cod { get; set; }
        public int Cnt { get; set; }
        public object City { get; set; }
    }
}
