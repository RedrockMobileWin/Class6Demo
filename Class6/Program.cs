using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 重用性
            Console.WriteLine("重载：");
            print("hello");
            print(5);
            Test1<int> a = new Test1<int>(5);
            Console.WriteLine("int:" + a.obj);
            Test1<string> b = new Test1<string>("Hello");
            Console.WriteLine("String:" + b.obj);
            Console.Read();
            #endregion
            #region 类型安全和效率
            ArrayList list1 = new ArrayList();
            List<int> list2 = new List<int>();


            list1.Add("2123");
            list1.Add(213.5);
            list1.Add(3.36f);
            list1.Add(4343);

            list2.Add(3);
            //list2.Add(2.3);
            //list2.Add("454");
            #endregion
            #region 泛型约束
            SortHelper<int> tempInt = new SortHelper<int>();
            //SortHelper<Book> tempBook = new SortHelper<Book>();
            #endregion
        }
        public static void print(string s)
        {
            Console.WriteLine("string:{0}", s);
        }
        public static void print(int i)
        {
            Console.WriteLine("int:{0}", i);
        }
    }
}
