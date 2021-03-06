﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class MyBinaryTree<T> where T:IComparable
    {
        public T nodeData { get; set; }
        public MyBinaryTree<T> leftTree { get; set; }
        public MyBinaryTree<T> rightTree { get; set; }
        public static int leftCount;
        public static int rightCount;
        bool result = false;
        /// <summary>
        /// Constructor to define node values
        /// </summary>
        /// <param name="nodeData"></param>
        public MyBinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        /// <summary>
        /// UC 1
        /// Insert data in binary tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.nodeData;
            int value = currentNodeValue.CompareTo(item);
            ///if entered new node data is less than parent data then it will be added to left
            if ((currentNodeValue.CompareTo(item))>0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                ///if entered new node data is more than parent data then it will be added to right
                if (this.rightTree==null)
                {
                    this.rightTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    this.rightTree.Insert(item);
                    Console.WriteLine("Inserting " + item);
                }
            }
        }
        /// <summary>
        /// Displays tree data
        /// </summary>
        public void Display()
        {
            if (this.leftTree != null)
            {
                leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                rightCount++;
                this.rightTree.Display();
            }
        }
        /// <summary>
        /// UC 2
        /// Returns the size of the tree
        /// </summary>
        public void Size()
        {
            Console.WriteLine((1 + leftCount + rightCount));
        }
        /// <summary>
        /// UC 3
        /// Searches for the given item
        /// </summary>
        /// <param name="item"></param>
        public void Search(T item)
        {
            T currentNodeValue = this.nodeData;
            int value = currentNodeValue.CompareTo(item);
            ///if entered new node data is less than parent data then it will move to left to search
            if (value > 0)
            {
                if (this.leftTree.nodeData.Equals(item))
                    Console.WriteLine("Got the item");
                else
                    this.leftTree.Search(item);
            }
            else
            {
                ///if entered new node data is more than parent data then it will move to right to search
                if (this.rightTree.nodeData.Equals(item))
                    Console.WriteLine("Got the item");
                else
                    this.rightTree.Search(item);
            }
        }
    }
}
