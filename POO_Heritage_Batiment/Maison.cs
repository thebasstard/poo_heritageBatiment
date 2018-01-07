using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Batiment
{
    class Maison : Batiment
    {
        private int nbPieces;

        public int NbPieces
        {
            get { return nbPieces; }
            set { nbPieces = value; }
        }


        public Maison() : base(){ } 

        public Maison(string a,int Np) : base(a)
        {
            nbPieces = Np;
        }

        public override string ToString()
        {
            return base.ToString() + " Nombre de pièces : " + nbPieces;
        }
    }
}
