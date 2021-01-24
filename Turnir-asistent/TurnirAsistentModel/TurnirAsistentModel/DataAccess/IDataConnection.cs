using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel.Models;

namespace TurnirAsistentModel.DataAccess
{
    public interface IDataConnection
    {
        NagradaModel NapraviNagradu(NagradaModel model);
        OsobaModel IzradiOsobu(OsobaModel model);
        EkipaModel IzradiEkipu(EkipaModel model);
        TurnirModel KreiranjeTurnira(TurnirModel model);
        List<EkipaModel> GetEkipa_All();
        List<OsobaModel> GetPeople_All();

    }
}
