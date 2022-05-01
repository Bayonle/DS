namespace LinkedList
{
    public class Node<T>
    {
        private T _data;

        public Node(T data)
        {
            _data = data;
        }
        public T Data { get => _data; }
        public Node<T> NextNode { get;set; }



        public override string ToString()
        {
            var next = NextNode == null ? "End" : NextNode.ToString();
            var nodeString = $"Node(data = {_data}) ----> {next}";
            return nodeString;
        }

        public bool IsTail()
        {
            return NextNode is null;
        }

        // public override bool Equals(object? obj)
        // {
        //     if((obj is null) || this.GetType().Equals(obj.GetType()))
        //         return false;

        //     else 
        //     {
        //         var node = (Node<T>)obj;
        //         return node.Data == this.Data;
        //     }
        // }
    }
}