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
            
            //Current Level
            int cLevel = 2;
            //Current level of nodes within the tree
            List<Node> currentLevel = new List<Node>();
            //Next level of nodes within the tree
            List<Node> nextLevel = new List<Node>();


            currentLevel.Add(root);
            Console.WriteLine();
            Console.WriteLine(root.Value);

            //Keep track of the last node created to keep track of neighbors
            Node last;

            //Loop through to the depth wanted for the tree and don't loop if depth is equal to 1
            while (cLevel <= depth && depth > 1)
            {
                //Make the last 
                last = currentLevel[0];
                for (int i = 0; i < currentLevel.Count; i++)
                {
                    //Create the left child
                    currentLevel[i].Left = new Node(currentLevel[i], currentLevel[i].Value + currentLevel[i].LValue);
                    //If it is the first node in the level set it's left to zero
                    if (i == 0)
                    {
                        currentLevel[i].Left.LValue = 0;
                    }
                    //Else set the right neighbor value of the previously created node to the right child's value
                    //And set the left neighbor value of the right child
                    else
                    {
                        last.RValue = currentLevel[i].Left.Value;
                        currentLevel[i].Left.LValue = last.Value;
                    }
                    //The last created node is the left child of the current node 
                    last = currentLevel[i].Left;
                    //Add to the next level of nodes
                    nextLevel.Add(last);
                    //Create right node
                    currentLevel[i].Right = new Node(currentLevel[i], currentLevel[i].Value + currentLevel[i].RValue);
                    last.RValue = currentLevel[i].Right.Value;
                    currentLevel[i].Right.LValue = last.Value;
                    last = currentLevel[i].Right;
                    nextLevel.Add(last);
                }
                //Print out each node of the current level to the command line
                foreach (Node n in nextLevel)
                {
                    Console.Write(n.Value + " ");
                }
                Console.WriteLine();

                //Clear the current node list
                currentLevel.Clear();

                //Create a new list with the contents of next 
                currentLevel = new List<Node>(nextLevel);

                //Clear nextLevel
                nextLevel.Clear();
                //Increase to the next level
                cLevel++;
            }
            currentLevel.Clear();
        }
    }
}
