using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    class Test1<T>
    {
        public T obj;
        public Test1(T obj)
        {
            this.obj = obj;
        }
    }
   

    public class SortHelper<T> where T : IComparable
    {
        public void Sort(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i <= length - 2; i++)
            {
                for (int j = length - 1; j >= 1; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }

    //自定义类实现IComparable接口
    public class Book/* : IComparable*/
    {
        private int price;
        private string title;

        public Book() { }

        public Book(int price, string title)
        {
            this.price = price;
            this.title = title;
        }

        public int Price
        {
            get { return this.price; }
        }

        public string Title
        {
            get { return this.title; }
        }

        public int CompareTo(object obj)
        {
            Book book = (Book)obj;
            return this.Price.CompareTo(book.Price);
        }
    }

}
