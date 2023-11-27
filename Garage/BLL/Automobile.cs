using System.Xml.Linq;

namespace BLL
{
    public class Automobile
    {
        public int Annee { get; set; }

        public String Immatriculation { get; set; }

        public Automobile(int Annee, String Immatriculation)
        {
            this.Annee = Annee;
            this.Immatriculation = Immatriculation;

        }


        public override string ToString()
        {
            return "Automobile: " + Annee.ToString() + " " + Immatriculation;
        }
    }



}