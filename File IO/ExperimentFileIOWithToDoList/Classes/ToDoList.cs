using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ExperimentFileIOWithToDoList;
namespace ExperimentFileIOWithToDoList.Classes
{
    class ToDoList
    {
        private int currentId = 0;
        public List<ToDo> toDoList;
        public ToDoList()
        {  //Constructor
            this.toDoList = new List<ToDo>();
        }//End of Constructor
        public ToDo AddNewToDo(ToDo pToDo)
        {
            this.currentId += 1; //Increment the Id
            //Populate the ToDo type object's properties.
            pToDo.Id = this.currentId;

            //Call Add method to add the ToDo object into the List<ToDo> todoList
            this.toDoList.Add(pToDo);
            return pToDo;
        }//End of AddNewToDo method
        public void UpdateToDo(ToDo pToDo)
        {  //Using a bit of LINQ technique here.
            ToDo todo = this.toDoList.Find(item => item.Id == pToDo.Id);
            todo.Title = pToDo.Title;
            todo.PriorityLevel = pToDo.PriorityLevel;
            todo.Status = pToDo.Status;
        }//End of UpdateToDo method
        public List<ToDo> GetToDoList()
        {
            return this.toDoList;
        }//End of GetToDoList
        public void Reposition(int pOriginalIndex,int pNewIndex, ToDo pToDo)
        {
            this.toDoList.RemoveAt(pOriginalIndex);
            this.toDoList.Insert(pNewIndex, pToDo);
        }//End of Reposition


    }//End of ToDoList class
}//End of namespace
