using System;
namespace Uebung57_DemoVererbungRechteck
{
    class Quadrat : Rechteck
    {




        public Quadrat(double laenge) : base(laenge, laenge)
        {

        }





        public override string ToString()
        {
            return $"Quadrat [Laenge={Laenge}]";
        }




    }
}
