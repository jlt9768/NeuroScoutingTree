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
