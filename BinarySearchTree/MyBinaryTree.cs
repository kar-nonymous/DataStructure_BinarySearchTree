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
        int leftCount = 0;
        int rightCount = 0;
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
        /// Insert data in binary tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.nodeData;
            int value = currentNodeValue.CompareTo(item);
            if((currentNodeValue.CompareTo(item))>0)
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
                if(this.rightTree==null)
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
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}
