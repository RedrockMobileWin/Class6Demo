using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Car driver = new Car();
            driver.OverspeedEvent += Car.MakeAlert;
            driver.OverspeedEvent += Car.Display;
            driver.Star();
        }
    }
    class Car
    {
        public delegate void DriveHandler(int V);
        public event DriveHandler OverspeedEvent;
        private int V;
        public void Star()
        {
            V = 0;
            for(int i=0;i<300;i++)
            {
                V++;
                if(V>280)
                {
                    if (OverspeedEvent != null)
                        OverspeedEvent(V);
                    //可以直接使用下面代替上面if
                   // OverspeedEvent?.Invoke(V);
                }
            }
        }
        public static void MakeAlert(int v)
        {
            Console.WriteLine("警告，飙车速度过快,速度={0}", v);
        }
        public static void Display(int v)
        {
            Console.WriteLine("当前速度={0}", v);
        }
        public int V1
        {
            get
            {
                return V;
            }

            set
            {
                V = value;
            }
        }
    }
    
}
