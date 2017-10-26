using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TreeExercise
{
    //Line for debugging purposes
    [DebuggerDisplay("Value = {value}  R = {rightValue} L = {leftValue}")]
    class Node
    {
        private Node parent;
        private Node leftChild;
        private Node rightChild;
        private int value;
        private int leftValue;
        private int rightValue;

        /// <summary>
        /// Getter and Setter for parent
        /// </summary>
        public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        /// <summary>
        /// Getter and Setter for left node
        /// </summary>
        public Node Left
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        /// <summary>
        /// Getter and Setter for right node
        /// </summary>
        public Node Right
        {
            get { return rightChild; }
            set { rightChild = value; }
        }
        /// <summary>
        /// Getter and Setter for parent
        /// </summary>
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        /// <summary>
        /// Getter and Setter for right neighbors value
        /// </summary>
        public int RValue
        {
            get { return rightValue; }
            set { rightValue = value; }
        }
        /// <summary>
        /// Getter and Setter for left neighbors value
        /// </summary>
        public int LValue
        {
            get { return leftValue; }
            set { leftValue = value; }
        }
        public Node()
        {
            parent = null;
            leftChild = null;
            rightChild = null;
            value = 1;
            leftValue = 0;
            rightValue = 0;
        }
        public Node(Node parent, int value)
        {
            this.parent = parent;
            leftChild = null;
            rightChild = null;
            this.value = value;
            leftValue = 0;
            rightValue = 0;
        }

    }
}
