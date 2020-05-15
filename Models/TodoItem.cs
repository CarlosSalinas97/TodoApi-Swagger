using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public string Key { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
