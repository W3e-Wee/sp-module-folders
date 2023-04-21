using ExperimentGeneralTreeBasicConcept.Classes;
using System;

namespace ExperimentGeneralTreeBasicConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structuring data to model a department hierachy");
            DepartmentNode treeNode1 = new DepartmentNode();
            treeNode1.Data = new Department(1, "Root");

            DepartmentNode treeNode2 = new DepartmentNode();
            treeNode2.Data = new Department(2, "Service");

            DepartmentNode treeNode3 = new DepartmentNode();
            treeNode3.Data = new Department(4, "Site");

            DepartmentNode treeNode4 = new DepartmentNode();
            treeNode4.Data = new Department(5, "Site A");

            DepartmentNode treeNode5 = new DepartmentNode();
            treeNode5.Data = new Department(6, "Site B");

            DepartmentNode treeNode6 = new DepartmentNode();
            treeNode6.Data = new Department(7, "Site C");

            DepartmentNode treeNode7 = new DepartmentNode();
            treeNode7.Data = new Department(8, "Internal");

            DepartmentNode treeNode8 = new DepartmentNode();
            treeNode8.Data = new Department(3, "Sales");


            treeNode1.AddNode(treeNode2); // Adds a child node (Service) to parent node (Root) 
            treeNode1.AddNode(treeNode8); // Adds a child node (Sales) to parent node (Root)

            treeNode2.AddNode(treeNode3); // Adds a child node (Site) to parent node (Service)
            treeNode2.AddNode(treeNode7); // Adds a child node (Internal) to parent node (Service)

            treeNode3.AddNode(treeNode4); // Adds a child node (Site A) to parent node (Site)
            treeNode3.AddNode(treeNode5); // Adds a child node (Site B) to parent node (Site)
            treeNode3.AddNode(treeNode6); // Adds a child node (Site C) to parent node (Site)

            PrintTree(treeNode1, "", false);
            Console.WriteLine("A tree structure department data has been built");
            Console.WriteLine("Search and Delete the department data with Id 8, Internal");
            treeNode1.SearchDeleteById(8);

            PrintTree(treeNode1, "", false);
            Console.WriteLine("A tree structure department data has been built");
            Console.WriteLine("Search and Delete the department data with Id 7, Site B");
            treeNode1.SearchDeleteById(7);
            PrintTree(treeNode1, "", false);
        }// End of Main

        public static void PrintTree(DepartmentNode inDepartmentNode, string pIndent, bool pLast )
        {
            DepartmentNode tree = inDepartmentNode;
            int numberOfChildNodes = tree.ChildNodes.Count;
            string indent = pIndent;
            Console.Write(indent);

            if (pLast)
            {
                // Both of these can be deleted to see the effects
                Console.Write("+-");
                indent += " ";
            }
            else
            {
                // Both of these also can be deleted to see the effects
                Console.Write("+-");
                indent += "| ";
            }

            Console.WriteLine(tree.Data.Name);  
            for(int i = 0; i < numberOfChildNodes; i++)
            {
                // Keep calling the PrintTree method
                PrintTree(tree.ChildNodes[i], indent ,i == numberOfChildNodes - 1);
            }// End of for loop
        }// End of PrintTree method
    }// End of Program class
}// End of namespace
