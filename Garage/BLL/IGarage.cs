
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGarage
    {
        string AddAuto(Automobile au);
        String updateAut(Automobile au);
        int getIndesxAuto(String a1);
        String deleteAuto(String imm);

        Automobile getAuto(String imm);

        List<Automobile> afficherAuTomobile(SubType sousType);
    }
    public enum SubType { Voiture, Moto };
}
