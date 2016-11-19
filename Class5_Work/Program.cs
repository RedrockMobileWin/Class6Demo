using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { Age = 10, Name = "小明", IdNum = "123456789" });
            list.Add(new Student() { Age = 11, Name = "大明", IdNum = "123456789" });
            list.Add(new Student() { Age = 13, Name = "中明", IdNum = "123456789" });
            list.Add(new Student() { Age = 12, Name = "明明", IdNum = "123456789" });
            //Student 类中写的按照Age排序
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine("Age={0},Name={1}", item.Age, item.Name);

            }



            //使用比较器，进行Name排序
            list.Sort(new ComparableName());
            foreach( var item in list)
            {
                Console.WriteLine("Age={0},Name={1}",item.Age,item.Name);
            }


           //使用 IEnumerable
            Case1 c1 = new Case1();
            c1.Name = "12345689";
            foreach(var i in c1.Name)
            {
                Console.WriteLine(i);
            }
            //使用IEnumerator
            Casel_1 c1_1 = new Casel_1() { Name = "wqertyuiop" };
   
            foreach(var i in c1_1.Name)
            {
                Console.WriteLine(i);
            }
        }
    }
}
