using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTodoList2
{
    internal class TodoTask
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
