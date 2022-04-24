// See https://aka.ms/new-console-template for more information

using Arrays;

using LinkedList;

var node1 = new Node<int>(2);
var node2 = new Node<int>(5);
var node3 = new Node<int>(10);
// node1.NextNode = node2;
// node2.NextNode = node3;
// System.Console.WriteLine(node2);

var list = new SinglyLinkedList<int>();
list.Prepend(1);
list.Prepend(2);
list.Prepend(3);
list.Prepend(0);

var result = list.Search(10);
System.Console.WriteLine(result);



// list.Head = node1;
// System.Console.WriteLine(list.Size());
// System.Console.WriteLine(node1.IsTail());