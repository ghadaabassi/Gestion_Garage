using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public static class VariablesPartages
    {
        public static List<Voiture> voitures = new List<Voiture>();
        public static List<Moto> motos = new List<Moto>();
        public static List<Automobile> automobiles = new List<Automobile>();
        public static Garage g1 = new Garage("Mon Garage",automobiles); 

    }
}
