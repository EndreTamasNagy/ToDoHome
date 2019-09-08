using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo
{
    public class Task
    {
        public string Title;
        public Sizes Size;
        public States State;
        public Task Parent;
        public List<Task> Children = new List<Task>();

    }
}
