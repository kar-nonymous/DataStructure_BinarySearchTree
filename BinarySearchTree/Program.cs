using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>(56);
            Console.WriteLine("Inserting-----");
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            myBinaryTree.Display();
        }
    }
}
