using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Console.WriteLine("Please enter the depth of the tree, needs to be greater than or equal to 1.");
            int depth;
            while(!int.TryParse(Console.ReadLine(),out depth) || depth < 1)
            {
                Console.WriteLine("Please enter the depth of the tree, needs to be greater than or equal to 1.");
            }           
            tree.CreateTree(depth);
            Console.ReadLine();
        }
    }
}
