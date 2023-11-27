

namespace BLL
{
    public class Voiture : Automobile
    {

        public String Couleur { get; set; }
        public String Marque { get; set; }
        public String TypeV { get; set; }

        public Voiture(int Annee, string Immatriculation, String Couleur, String Marque, String TypeV) : base(Annee, Immatriculation)
        {
            this.Couleur = Couleur;
            this.Marque = Marque;
            this.TypeV = TypeV;
        }

       
        public override string ToString()
        {
            return base.ToString() + " Couleur: " + Couleur + " Marque: " + Marque + " TypeV: " + TypeV;
        }


    }
}
