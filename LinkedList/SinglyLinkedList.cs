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
        ///Adds the data to the list. (becomes the head).
        ///runs in O(1)
        ///</summary>
        public void Prepend(T data)
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

        public override string ToString()
        {

            return Head.ToString();

        }
    }

}