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
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(0);
System.Console.WriteLine(list);
// list.InsertAfter(new Node<int>(2), new Node<int>(50));
// list.InsertAt(0, 345);
list.Remove(0);
System.Console.WriteLine(list);



// var result = list.Search(1);
// System.Console.WriteLine(result);

// System.Console.WriteLine("xt".ToCharArray().ToArray());

// string s = "sw-T@";
// var newArray = s.ToArray();
// var reversedArray = new string[newArray.Length];
// for(var i = 0; i <= newArray.Length; i++)
// {
//     if (char.IsLetter(newArray[i]))
//     {
//         reversedArray[newArray.Length - (i + 1)] = newArray[i].ToString();
//     }
//     else
//     {
//         reversedArray[i] = newArray[i].ToString();
//     }
// }
// var result = string.Join("", reversedArray.ToArray());
// System.Console.WriteLine(result);

// list.Head = node1;
// System.Console.WriteLine(list.Size());
// System.Console.WriteLine(node1.IsTail());








// var ops = new string[]{"5", "2", "C", "D", "+"};
// var s = "{}[]";
// var solution = new Solution();
// System.Console.WriteLine(solution.IsValid(s));

// class Solution
// {
//     public int CalPoints(string[] ops)
//     {
                
//         var strangeRules = new List<string>{"C", "D", "+"};
//         Dictionary<int, int> dict = new Dictionary<int, int>();
//         var newArray = new List<int>();
//         for(var i = 0; i < ops.Length; i++)
//         {
//             var op = ops[i];
//             if(op == "+")
//             {
//                 newArray.Add(newArray[newArray.Count() - 1] + newArray[newArray.Count() - 2]);
//             }
//             else if (op == "D")
//             {
//                 var value = 2 * newArray[newArray.Count() - 1];
//                 newArray.Add(value);
//             }
//             else if(op == "C")
//             {
//                 newArray.RemoveAt(newArray.Count() - 1);
//                 // newArray.RemoveAt(i - 1);
//             }
//             else newArray.Add(int.Parse(ops[i]));
//         }

//         return newArray.Sum(x => x);


//     }

//     public bool IsValid(string s)
//     {
//         var charArray = s.ToCharArray();
//         bool isValid = false;
//         for(var i = 0; i < charArray.Length; i++)
//         {
//             char c = charArray[i];
//             if(c == '(')
//             {
//                 isValid = charArray[i + 1] == ')';
//             }
//             else if(c == '{')
//             {
//                 isValid = charArray[i + 1] == '}';
//             }
//             else if(c == '[')
//             {
//                 isValid = charArray[i + 1] == ']';
//             }
//             if(isValid) i++;
//             else return false;
            
//         }

//         return isValid;
//     }
// }


