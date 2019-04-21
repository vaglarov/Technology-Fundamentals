using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ToDoList.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Comments { get; set; }
    }
}
