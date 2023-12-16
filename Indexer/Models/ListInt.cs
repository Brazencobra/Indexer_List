using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Models
{
    internal class ListInt
    {
        private int[] _arr;

        public int this[int index] 
        {
            get 
            {
                if (index < _arr.Length)
                {
                    return _arr[index];   
                }
                throw new IndexOutOfRangeException();
            }
            set 
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new Exception();
            }
        }

        public ListInt()
        {
            _arr = new int[0];
        }

        public ListInt(int number)
        {
            _arr = new int[number];
        }

        public ListInt(int[] arr)
        {
            _arr = arr;
        }

        public void ForeachList()
        {
            foreach (int item in _arr)
            {
                Console.WriteLine(item);
            }
        }

        public void Add(int number)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = number;
        }
        public void Add(params int[] numbers)
        {
            Array.Resize(ref _arr,_arr.Length + numbers.Length);
            for (int i = _arr.Length - numbers.Length; i < _arr.Length; i++)
            {
                _arr[i] = numbers[i-numbers.Length];
            }
        }

        /*Paramsla yazilan Add metodunda problem var hellini tapdigim zaman yeni commitle duzelis edecem
        Problem:Eger 0 uzunluga sahib arraye yeni ededler elave edirikse o zaman setir 68-de problem yaranir.Sebebi ise i ilk periodda 0 olur ve bu zaman ondan her hansi bir ededi cixsaq menfi bir eded alinir.Eslinde helli cox da cetin deyil if-le hell etmek olar amma basqa vaxta qalsin :)*/

        public bool Contains(int number) 
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == number) return true;
            }
            return false;
        }

        public int Pop()
        {
            int number = _arr[_arr.Length - 1];
            Array.Resize(ref _arr, _arr.Length - 1);
            return number;
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int item in _arr)
            {
                sum += item;
            }
            return sum;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _arr.Length; i++)
            {
                sb = sb.Append(_arr[i]);
            }
            return sb.ToString();
        }

    }
}
