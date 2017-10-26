using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Tree
    {
        private Node root = new Node();
        public Node Root
        {
            get { return root; }
        }

        /// <summary>
        /// Methods used to create the tree
        /// </summary>
        /// <param name="depth">How deep the tree is to go</param>
        public void CreateTree(int depth)
        {
            while (depth < 1)
            {
                Console.WriteLine("Depth needs to be great than or equal to 1");
                depth = Convert.ToInt32(Console.ReadLine());
            }
            //Current Level
            int cLevel = 2;
            //Current level of nodes within the tree
            List<Node> currentLevel = new List<Node>();
            //Next level of nodes within the tree
            List<Node> nextLevel = new List<Node>();


            currentLevel.Add(root);
            Console.WriteLine(root.Value);

            //Keep track of the last node created to keep track of neighbors
            Node last;

            //Loop through to the depth wanted for the tree and don't loop if depth is equal to 1
            while (cLevel <= depth && depth > 1)
            {

            }
        }
    }
}
