using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin1.ViewModels
{
    internal class Soxrdann
    {
       public static List<ClassUser> pers = [new ClassUser("admin","admin",true),new ClassUser("user","user",false)];

        //public static List<Tovarclass> products1 = [new Tovarclass("1",1,1,1,1)] ;
        public static List<Tovarclass> products1 = new();
        public static List<Tovarclass> productsBascket = new();
        public static int[] teg=new int[1];
        public static int[] dobtov = new int[10];








    }
}
