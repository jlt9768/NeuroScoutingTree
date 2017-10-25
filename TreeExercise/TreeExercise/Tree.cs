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
            get { return root;}
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
        }
    }
}
