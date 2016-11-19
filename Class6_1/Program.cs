using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //定义一个委托
        public delegate void sayHi(string name);
        static void Main(string[] args)
        {
            #region 方法做参数
            Hi("QZ", EnglishHi);
            #endregion
            #region +=注册方法
            //sayHi tempHi+= ChineseHi;//不是在未初始化的委托上用
            //sayHi tempHi2 = new sayHi(ChineseHi);
            //tempHi2("叶总");

            sayHi tempHi2 = ChineseHi;//先赋值
            tempHi2 += EnglishHi;//再绑定一个方法
            tempHi2("yezhou2");
            #endregion
        }
        public static void Hi(string name, sayHi typeHi)
        {
            typeHi(name);
        }
        public static void EnglishHi(string englishName)
        {
            Console.WriteLine("Hi,{0}", englishName);
        }
        public static void ChineseHi(string chineseName)
        {
            Console.WriteLine("(｡･∀･)ﾉﾞ嗨,{0}", chineseName);
        }
    }

}
