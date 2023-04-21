using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ExperimentFileIOWithToDoList.Classes
{

    class ToDo
    {
        public ToDo()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int PriorityLevel { get; set; }//0=low priority, 1=medium priority, 2 = high priority
        public bool Status { get; set; } //0=not done, 1=done
    }
}
