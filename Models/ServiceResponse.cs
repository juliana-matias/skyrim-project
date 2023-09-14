using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skyrim_project.Models
{
    public class ServiceResponse<T> //T is the actual type of the data we want to return
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true; // we can tell frontend everything went right
        public string Message { get; set; } = string.Empty; // by default ; explanatory message in case of an error
    }
}
