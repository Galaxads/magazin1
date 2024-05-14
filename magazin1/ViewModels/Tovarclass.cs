using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin1.ViewModels
{
    internal class Tovarclass
    {
        private string names = "1";
        private double prices = 23;
        
        private int ids = 0;
        private int colvos = 0;
        public int colvos1 = 1;
        

        public Tovarclass(string? name, double price, int colvo, int id,int colvos_1)
        {
            names = name;
            prices = price;          
            ids = id;
            colvos = colvo;
           colvos1=colvos_1;
            
        }



        public string Name
        {
            get { return names; }
            set { names = value; }
        }

        public double Price
        {
            get { return prices; }
            set { prices = value; }
        }


        public int Id
        {
            get { return ids; }
            set { ids = value; }
        }
        public int Colvo
        {
            get { return colvos; }
            set { colvos = value; }
        }
        public int Colvo1
        {
            get { return colvos1; }
            set { colvos1 = value; }
        }
    }
}
