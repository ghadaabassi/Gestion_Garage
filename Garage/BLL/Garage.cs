


namespace BLL
{

    public class Garage : IGarage
    {
        private String Adresse { get; set; }
        public List<Automobile> listauto { get; set; }

        public Garage(String Adresse, List<Automobile> listauto)
        {
            this.Adresse = Adresse;
            this.listauto = listauto;
        }

        public string AddAuto(Automobile au)
        {
            try
            {
                listauto.Add(au);
                return "Automobile Added with Success ";
            }
            catch
            {
                return "Somthing went wrong";
            }

        }

        public string updateAut(Automobile au)
        {
            if (getIndesxAuto(au.Immatriculation) >= 0)
            {
                listauto[getIndesxAuto(au.Immatriculation)] = au;
            }

            return "Automobile Does not Exist";
        }

        public int getIndesxAuto(string a1)
        {
            for (int i = 0; i < listauto.Count; i++)
            {
                if (listauto[i].Immatriculation == a1)
                {
                    return i;
                }
            }
            return -1;
        }

        public string deleteAuto(string imm)
        {
            if (getIndesxAuto(imm) >= 0)
            {
                listauto.Remove(listauto[getIndesxAuto(imm)]);
            }

            return "Automobile Does not Exist";
        }

        public Automobile getAuto(string imm)
        {
            if (getIndesxAuto(imm) >= 0)
            {
                return listauto[getIndesxAuto(imm)];
            }

            return null;

        }

        public List<Automobile> afficherAuTomobile(SubType sousType)
        {
            List<Automobile> list = new List<Automobile>();
            for (int i = 0; i < listauto.Count; i++)
            {
                if (listauto[i].GetType().Name.Equals(sousType.ToString()))
                {
                    list.Add(listauto[i]);
                }
            }

            return list;
        }
    }
}
