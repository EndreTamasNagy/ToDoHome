using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDo.Pages
{
    public class TodoModel : PageModel
    {
        public List<Task> Tasks { get; set; }
        public Task Parent { get; set; }
        public void OnGet()
        {
            Tasks = new List<Task>(){
                new Task(){Title="Automating", Size=Sizes.XL, State=States.ToStart},
                new Task(){Title="Planning", Size=Sizes.XL, State=States.ToStart},
                new Task(){Title="Profit", Size=Sizes.XL, State=States.ToStart}
            };
            Parent = new Task() { Title = "parent task", Size = Sizes.XL, State = States.ToStart, Children = Tasks };
        }
    }
}