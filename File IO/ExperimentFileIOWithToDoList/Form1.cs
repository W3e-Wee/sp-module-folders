//File IO experiment with ToDoList project
using ExperimentFileIOWithToDoList.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentFileIOWithToDoList
{
    public partial class Form1 : Form
    {
        ToDoList toDoList;
        bool updateMode = false;
        bool addMode = true;
        ListViewItem selectedListViewItem;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioLow.Checked = true;//When the form loads, you need this radio button control selected.
            //The toDoList variable has been declared as a "class scope variable".
            //Meaning: Declared inside the Form1 class, and declared outside all other methods.
            //As a result, toDoList can be seen and manipulated by any code inside the Form1 class
            //methods.
            this.toDoList = new ToDoList();

            //Define 3 column headers for the Listview control.
            //I have referred to the https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.columnheader.width?view=netcore-3.1
            //tutorial to prepare the code.
            ColumnHeader header1, header2, header3;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();
            header3 = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            header1.Text = "Title";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 210;

            header2.TextAlign = HorizontalAlignment.Left;
            header2.Text = "Priority level";
            header2.Width = 110;

            header3.TextAlign = HorizontalAlignment.Left;
            header3.Text = "Status";
            header3.Width = 100;

            // Add 3 headers to the ListView control.
            listviewToDoList.Columns.Add(header1);
            listviewToDoList.Columns.Add(header2);
            listviewToDoList.Columns.Add(header3);

            //If you don't use the View property, you won't see the column header title.
            this.listviewToDoList.View = View.Details;
            this.listviewToDoList.AllowDrop = true;
            this.listviewToDoList.FullRowSelect = true;
            this.listviewToDoList.MultiSelect = false;
            //Programatically use code to define which method handles the Listview control's events.
            listviewToDoList.MouseDown += new MouseEventHandler(listviewToDoList_MouseDown);
            listviewToDoList.MouseUp += new MouseEventHandler(listviewToDoList_MouseUp);
            listviewToDoList.DragDrop += new DragEventHandler(listviewToDoList_DragDrop);
            listviewToDoList.DragOver += new DragEventHandler(listviewTodoList_DragOver);

            //Call this ResetFormState method to set the controls and class scope variables to 
            //the "original state".
            ResetFormState();

        }//End of Form1_Load

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo();
            //Collect data from the respective controls.
            toDo.Title = textToDoTitle.Text;
            toDo.Status = checkStatus.Checked; //This Checked property returns either true or false.
            if (radioHigh.Checked)
            {
                toDo.PriorityLevel = 2;
            }//End If
            if (radioMedium.Checked)
            {
                toDo.PriorityLevel = 1;
            }//End If
            if (radioLow.Checked)
            {
                toDo.PriorityLevel = 0;
            }//End If

            if (this.addMode == true)
            {
                //Call the AddNewToDo method which belongs to the toDoList object.
                //The method returns a populated ToDo type object which is needed by
                //subsequent code to display one row of To Do data inside the ListView control.
                ToDo newToDo = this.toDoList.AddNewToDo(toDo);

                //Add a new ListViewItem class object into the List View control.
                //The newToDo object's Id property has a numeric value (e.g. 1, 2, 3 etc).
                ListViewItem lvi = new ListViewItem(newToDo.Title);
                lvi.SubItems.Add(newToDo.PriorityLevel.ToString());
                lvi.SubItems.Add(newToDo.Status.ToString());
                lvi.Tag = newToDo; //Set the Tag property to reference the newToDo object
                listviewToDoList.Items.Add(lvi);
                ResetFormState();
            }//End if for creating a new ToDo object
            if (this.updateMode == true)
            {
                //For this windows form example, you have a class scope ListViewItem object which
                //references the data which was selected to update. You need to grab the Id information
                //from this.selectedListViewItem.Tag property so that, you can find and update the "correct" to do data.
                toDo.Id = ((ToDo)this.selectedListViewItem.Tag).Id;

                this.toDoList.UpdateToDo(toDo);
                //Subsequent code updates the correct SubItems collection which belongs to 
                //the respective ListViewItem. So that the updated data is displayed inside the ListView control.
                this.selectedListViewItem.SubItems[0].Text = toDo.Title;
                this.selectedListViewItem.SubItems[1].Text = toDo.PriorityLevel.ToString();
                this.selectedListViewItem.SubItems[2].Text = toDo.Status.ToString();
                this.selectedListViewItem.Tag = toDo;
                ResetFormState();
            }//End if for updating ToDo object
        }//End of buttonSave_Click
        private void buttonNew_Click(object sender, EventArgs e)
        {  //Objective: Clear the controls so that the user can provide new values.
            //Set the addMode to true and updateMode to false.
            ResetFormState();
        }//End of buttonnew_Click
        private void ResetFormState()
        {
            //Objective: To reset the important variables to their original values (when the program starts)
            //To reset or clear the input controls.

            this.textToDoTitle.Text = "";
            checkStatus.Checked = false;
            this.radioLow.Checked = true;

            //Set the following variables so that your logic
            //can notice that the form is in add new mode.
            this.addMode = true;
            this.updateMode = false;

            //No point letting the user click the New button
            this.buttonNew.Enabled = false;
        }//End of ResetFormState

        private void listviewToDoList_MouseDown(object sender, MouseEventArgs e)
        {
            this.selectedListViewItem = GetItemFromPoint(this.listviewToDoList, Cursor.Position);
            if (this.selectedListViewItem == null)
            {
                return;
            }
            this.listviewToDoList.DoDragDrop(this.selectedListViewItem, DragDropEffects.Move);
            ToDo toDo = new ToDo();
            toDo = (ToDo)selectedListViewItem.Tag;
            Debug.WriteLine(String.Format("Logic in listviewToDoList_MouseDown method has captured that:\n " +
                " Id {0}, \nTitle {1}, \nPriority {2}, \nStatus {3} is selected.", toDo.Id,
                toDo.Title,
                toDo.PriorityLevel,
                toDo.Status));
            //Populate the controls
            //to show the selected data.
            this.textToDoTitle.Text = toDo.Title;
            switch (toDo.PriorityLevel)
            {
                case 2: radioHigh.Checked = true; break;
                case 1: radioMedium.Checked = true; break;
                case 0: radioLow.Checked = true; break;
            }//End switch block
            this.checkStatus.Checked = toDo.Status;
            //Set the following variable values so that the form logic knows that 
            //it is in update existing data mode.
            this.updateMode = true;
            this.addMode = false;
            this.buttonNew.Enabled = true;
        }//End of listviewToDoList_MouseDown
        private void listviewToDoList_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.selectedListViewItem == null)
            {
                return;
            }
            Debug.WriteLine("Executing the listviewTodoList_MouseUp method");
            /* The following code segment attempts to find the ListViewItem object when the mouse was released .
               So that, you can obtain the index of that item. The index is needed by the ListView control's Insert method 
                to decided the insertion location of the other item you have been dragging */
            int newPositionIndex = 0;
            int originalPositionIndex = this.selectedListViewItem.Index;
            ListViewItem item = GetItemFromPoint(this.listviewToDoList, Cursor.Position);
            if (item == null)
            {
                newPositionIndex = this.listviewToDoList.Items.Count - 1;
            }
            else
            {
                newPositionIndex = item.Index;
            }
            ToDo selectedToDoForRepositionInList = (ToDo)this.selectedListViewItem.Tag;
            //Reposition the ToDo object inside the List
            this.toDoList.Reposition(originalPositionIndex,newPositionIndex, selectedToDoForRepositionInList);

            //The this.selectedListViewItem is referencing the item which was clicked
            //(when you hold down your mouse left button). When you are dragging
            //the item, the form's logic is able to "remember" the item which you are dragging.
            //When MouseUp event is raised, the logic below will remove the ListViewItem 
            //which is referenced
            //by the this.selectedListViewItem from the ListView. Then, the ListViewItem object is 
            //inserted into the ListView control at a new position.
            this.listviewToDoList.Items.Remove(this.selectedListViewItem);
            this.listviewToDoList.Items.Insert(newPositionIndex, this.selectedListViewItem);
            this.selectedListViewItem.Selected = true;
            Debug.WriteLine("Checking the sequence of all the objects inside the List after the re-position logic");
            foreach (var toDo in this.toDoList.GetToDoList())
            {
                Debug.WriteLine(toDo.Title);
            }
        }//End of  listviewToDoList_MouseUp
        private void listviewTodoList_DragOver(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Executing the listviewTodoList_DragOver method");
            e.Effect = DragDropEffects.Move;
            //Using the following code to provide highlight row effect when you are
            //doing a dragging action within the ListView control.
            ListViewItem item = GetItemFromPoint(this.listviewToDoList, Cursor.Position);
            if (item != null)
            {
                item.Selected = true;
            }
            //Note: Without the code inside the listviewToDoList_DragOver method, 
            //you can't provide the highlight animation effect when you are dragging a selected ListViewItem object.
        }//End of  listviewTodoList_DragOver
        private ListViewItem GetItemFromPoint(ListView listView, Point mousePosition)
        {
            // Translate the mouse position from screen coordinates to 
            // client coordinates within the given ListView
            Point localPoint = listView.PointToClient(mousePosition);
            return listView.GetItemAt(localPoint.X, localPoint.Y);
        }//End of GetItemFromPoint

        private void listviewToDoList_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Executing the listviewTodoList_DragDrop method");
            //The final code sample for learners DOES NOT use the listviewToDoList_DragDrop method.
            //When I was coding the listviewToDoList_DragDrop method, I have provided the necessary code
            //to remove the selected item from the ListView control and insert the same selected item into the
            //ListView control.
            //This technique was shared by developers in online articles such as:
            //https://stackoverflow.com/questions/35198652/listview-dragdrop-re-order-for-listview-in-details-view-code-usage
            //But I preferred to apply methods which handle mouse events instead as discussed at:
            //https://stackoverflow.com/questions/19405328/reorder-move-dragdrop-listviewitems-within-the-same-listview-control-in-c-sh
        }//End of listviewToDoList_DragDrop
 

        }//End of Form1 class
}//End of namespace
