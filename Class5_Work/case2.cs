using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Work
{
    public class Student : IComparable<Student>
    {
        private string name;
        private string idNum;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string IdNum
        {
            get
            {
                return idNum;
            }

            set
            {
                idNum = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int CompareTo(Student other)
        {
            if (this.Age > other.Age)
                return 1;
            else
                return -1;
        }
    }


    public class ComparableName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);

        }


    }
}