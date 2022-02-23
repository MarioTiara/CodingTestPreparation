using System;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.addNote(new Node(5));
            bt.addNote(new Node(4));
            bt.addNote(new Node(6));
            bt.addNote(new Node(7));
            bt.addNote(new Node(3));

            Console.WriteLine(BinaryTree.searchValue(bt.root, 8));
        }
    }
}
