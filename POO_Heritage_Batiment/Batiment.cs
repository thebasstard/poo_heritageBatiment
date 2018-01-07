using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Batiment
{
    class Batiment
    {

        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }



        public Batiment(){} //constructeur

        public Batiment(string a)
        {
            adresse = a;
        }

        public override string ToString()
        {
            return "Adresse: " + adresse;
        }
        
    }
}
