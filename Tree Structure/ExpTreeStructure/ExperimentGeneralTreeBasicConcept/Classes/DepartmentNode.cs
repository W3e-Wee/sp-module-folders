using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentGeneralTreeBasicConcept.Classes
{
    internal class DepartmentNode
    {
        // Construtor for DepartmentNode class
        public DepartmentNode()
        {
            this.ChildNodes = new List<DepartmentNode>();
        }

        public Department Data
        {
            get;
            set;
        }

        public DepartmentNode Parent
        {
            get;
            set;
        }

        public List<DepartmentNode> ChildNodes
        {
            get;
            set;
        }

        public void AddNode(DepartmentNode pDepartmentNode)
        {
            if (!this.ChildNodes.Contains(pDepartmentNode))
            {
                // Before inserting the "new" DepartmentNode object
                // into the list, set the Parent property to reference
                // the current parent.
                pDepartmentNode.Parent = this;
                this.ChildNodes.Add(pDepartmentNode);
            }
        }// End of AddNode method

        public void SearchDeleteById(int pDepartmentId)
        {
            // sanity check
            //Console.WriteLine("Id {0}, Department name: {1}", tree.Data.DepartmentId, tree.Data.Name);

            if(this.ChildNodes.Count > 0)
            {
                int i = 0;
                for(i = 0; i < this.ChildNodes.Count; i++)
                {
                    if(this.ChildNodes[i].Data.DepartmentId == pDepartmentId)
                    {   // Base case (Where the method code stops calling itself, performs action and finally exits)
                        // Avoids infinite loop
                        this.ChildNodes.RemoveAt(i); // Use built in RemoveAt() method
                        return;
                    }
                    else
                    {   // Recursive case (where the method calls itself)
                        // Each DepartmentNode type object has SearchDeleteById method
                        this.ChildNodes[i].SearchDeleteById(pDepartmentId);
                    }
                }
            }
        }// End of SearchDeleteById
    }
}
