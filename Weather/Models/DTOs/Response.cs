using System;
namespace Weather.Models.DTOs
{
    public class Response<T>
    {
        public bool Succeeded { get; set; }
        public T Payload { get; set; }
        public string Error { get; set; }
    }
}
