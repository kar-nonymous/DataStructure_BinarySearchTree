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
            myBinaryTree.Insert(22);
            myBinaryTree.Insert(40);
            myBinaryTree.Insert(60);
            myBinaryTree.Insert(95);
            myBinaryTree.Insert(11);
            myBinaryTree.Insert(65);
            myBinaryTree.Insert(3);
            myBinaryTree.Insert(16);
            myBinaryTree.Insert(63);
            myBinaryTree.Insert(67);
            myBinaryTree.Display();
            myBinaryTree.Search(40);
        }
    }
}
