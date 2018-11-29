using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Comments { get; set; }
    }
}
