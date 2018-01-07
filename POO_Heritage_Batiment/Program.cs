using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Batiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment GarageAbite = new Batiment("15 rue du zgueg");
            Console.Out.WriteLine(GarageAbite);

            Maison ETmaison = new Maison("rue des cons ",4);
            Console.Out.WriteLine(ETmaison);

            Maison AutreZonzon = new Maison();
            AutreZonzon.Adresse = "rue des deps ";
            AutreZonzon.NbPieces = 8;
            Console.Out.WriteLine(AutreZonzon);

            Console.ReadKey(); 
        }
    }
}
