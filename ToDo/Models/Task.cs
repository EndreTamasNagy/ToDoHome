using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Task
    {
        public string Title { get; set; }
        public States State { get; set; }
        public Complexity Complexity { get; set; }
        public string Description { get; set; }
    }
    public enum Complexity
    {
        XS,
        S,
        M,
        L,
        XL
    }
    public enum States
    {
        ToStart,
        InProgress,
        Completed
    }
}
