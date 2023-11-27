using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Moto : Automobile
    {
        public float VitesseMax { get; set; }
        public float Cylindre { get; set; }
        public Moto(int Annee, string Immatriculation, float vitesseMax, float cylindre) : base(Annee, Immatriculation)
        {
            this.VitesseMax = vitesseMax;
            this.Cylindre = cylindre;
        }

        public override string ToString()
        {
            return base.ToString() + " vitesseMax: " + VitesseMax.ToString() + " Cylindre: " + Cylindre.ToString();
        }


    }
}
