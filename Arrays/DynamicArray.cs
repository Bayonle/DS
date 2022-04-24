using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class DynamicArray<T>
    {
        public DynamicArray(T[] array)
        {
            if (array is null)
                throw new ArgumentNullException("array cannot be null");

            _array = array;
            _length = array.Length;
            _capacity = array.Length;
        }
        private T[] _array;
        private int _length;
        private int _capacity;
        public int Length { get { return _length; } }

        public void Print()
        {
            System.Console.WriteLine($"[{string.Join(',', _array)}]");
        }
        //[0,1,2,3]
        //capacity == length; capacity = 8
        public void Append(T value)
        {
            // create a new array with space greater than space of the original array
            T[] result = _array;
            //we need to know the point of insertion due to the fact that
            //once capacity is increased, c# will represents the remaining values
            //with their default. Not doing that will put your value to append
            //as the last item of the new array e.g 
            //[0,1,2,3,4].append(6) = [0,1,2,3,4,0,0,0,6]
            if (_capacity == _array.Length) //increase array capacity
            {
                _capacity *= 2;
                //copy all existing elements of the original array into new array
                for (var i = 0; i < _array.Length; i++)
                {
                    result[i] = _array[i];
                }
            }

            result[_array.Length] = value;
            _array = result;
        }

        public void InsertAt(int index, T value)
        {
            if (index > _array.Length || index < 0)
                throw new IndexOutOfRangeException("insertion point not available in original list");

            //new     
            T[] result = _array;
            if (_capacity == _array.Length)
            {
                _capacity *= 2;
                //increased capacity
                result = new T[_capacity];
            }

            for (int i = 0, j = 0; i < _array.Length; i++, j++)
            {
                if (index == j)
                {
                    result[j] = value; //insert 5 at index 1 [2,3,4] [2,5]
                    i--; //i needs to lag behind so we can pick the item we shifted
                }
                else
                {
                    result[j] = _array[i];
                }
            }
            _array = result;
        }

        public int IndexOf(T searchValue)
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(searchValue))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if(index >= _length) throw new InvalidOperationException("Index must be less than length of array");
            var result = new T[_length-1];
            for (int i = 0, j = 0; i < _array.Length; i++, j++)
            {
                if (i == index)
                {
                    j--;
                    continue;
                } //[1,2,3] -> 1

                result[j] = _array[i];
            }
            _array = result;
        }

        //removes first occurrence of specified item
        public bool Remove(T item)
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


    }
}