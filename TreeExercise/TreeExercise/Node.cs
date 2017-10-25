using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Node
    {
        private Node parent;
        private Node leftChild;
        private Node rightChild;
        private int value;
        public Node()
        {
            parent = null;
            leftChild = null;
            value = 1;
        }
        public Node(Node parent)
        {
            this.parent = parent;
            leftChild = null;
            rightChild = null;
            value = 1;
        }
        public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public Node Left
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        public Node Right
        {
            get { return rightChild; }
            set { rightChild = value; }
        }
        public int Value
        {
            get { return value; }
        }
    }
}
