using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        private int Value;
        public Node leftChild;
        public Node rightChild;

        public Node (int value)
        {
            this.Value = value;
        }

        public int getValue ()
        {
            return Value;
        }


    }
}
