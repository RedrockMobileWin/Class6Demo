using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Work
{
    class Case1 : IEnumerable
    {
        public string Name { get; set; }
        public IEnumerator GetEnumerator()
        {
            foreach (char item in Name)
                yield return item;
        }
    }
    class Casel_1 : IEnumerator
    {
       public string Name { get; set; }
        private int index;
        public object Current
        {
            get
            {
                return Name[index];
            }
        }

        public bool MoveNext()
        {
            index++;
            return index < Name.Length ? true : false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
