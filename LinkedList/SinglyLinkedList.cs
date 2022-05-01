using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList<T>
    {
        //contins only the reference to the head
        public Node<T>? Head {get;set;}
        
        public bool IsEmpty()
        {
            return Head is null;
        }


        ///<summary>
        ///returns the number of nodes in the list.
        ///runs in O(n)
        ///</summary>
        public int Size()
        {
            var currentNode = Head;
            var size = 0;

            //visit all node 
            while(currentNode is not null)
            {
                size++;
                currentNode = currentNode.NextNode;
            }

            return size;
        }

        ///<summary>
        ///Adds the data to the beginning of the list. (becomes the head).
        ///runs in O(1)
        ///</summary>
        public void Add(T data)
        {
            //store starting head cos it will be overwritten            
            var currentHead = Head; 
            //if there is no head then set Head to incoming node
            //else set Head to incoming 
            Head = new Node<T>(data);
            Head.NextNode = currentHead;
        }


        ///<summary>
        ///Search for the node containing the serach value. 
        ///Returns the node if found or null if not found.
        ///Runs in O(n)
        ///</summary>
        public Node<T> Search(T data)
        {
            var current = Head;
            while(current is not null)
            {
                if(current.Data.Equals(data))
                {
                    return current;
                }
                current = current.NextNode;
            }
            return null;
        }

        ///<summary>
        ///Insert a new node after a specified node.
        ///Insertion takes constant time O(1).
        ///Finding the node takes a linear time O(n)
        ///</summary>
        public void InsertAfter(Node<T> node, Node<T> newNode)
        {
            //we need to search for the node first
            //then update it's reference to the new node
            var currentNode = Head;
            Node<T> restOfNodes;
            while(currentNode is not null)
            {
                if(currentNode.Data.Equals(node.Data))
                {
                    //store the next reference to the current node
                    //update next node of the current node to the new node
                    //update next node of the new node to the stored nodes
                    restOfNodes = currentNode.NextNode;
                    currentNode.NextNode = newNode;
                    newNode.NextNode = restOfNodes;
                    return;
                }
                currentNode = currentNode.NextNode;
            }
        }

        ///<summary>
        ///Insert a new node at a specific index.
        ///Insertion takes constant time O(1).
        ///Finding the node takes a linear time O(n)
        ///</summary>
        public void InsertAt(int index, T newData)
        {
            //we need to search for the node first
            //then update it's reference to the new node
            var newNode = new Node<T>(newData);
            if(index == 0)
            {
                //head of node
                this.Add(newData);
                return;
            }
            
            //since we are not inserting at head of list
            //we can assume we've gone through 1 iteration
            int position = 1;
            //node to start iterating from would be the next to the head then
            var currentNode = Head.NextNode;
            //we need to keep a reference to the previous node 
            //before advancing to the next node
            //since currentnode is the node after the head
            //then previous node is head
            Node<T> previousNode = Head;
            while(currentNode is not null)
            {
                if(index == position)
                {
                    previousNode.NextNode = newNode;
                    newNode.NextNode = currentNode;
                    return;

                }
                position += 1;
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }
        }

        ///<summary>
        ///Removes a specified data from the list.
        ///Runs in O(n) due to having to transverse the list
        ///</summary>
        public void Remove(T data)
        {
            var currentNode = Head;
            Node<T> previousNode = null;
            while(currentNode is not null)
            {
                if(currentNode.Data.Equals(data))
                {
                    if(previousNode is null) //then we are at the head
                        Head = currentNode.NextNode;
                    else
                        previousNode.NextNode = currentNode.NextNode;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }
        }

        public override string ToString()
        {

            return Head.ToString();

        }
    }

}