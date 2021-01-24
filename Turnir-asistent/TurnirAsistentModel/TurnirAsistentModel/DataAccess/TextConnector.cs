using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel.Models;
using TurnirAsistentModel.DataAccess.TextHelpers;

namespace TurnirAsistentModel.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string NagradaFile = "NagradaModels.csv";
        private const string OsobaFile = "OsobaModels.csv";
        private const string EkipaFile = "EkipaModels.csv";
        private const string TurnirFile = "TurnirModel.csv";

        public List<OsobaModel> GetPeople1_All()
        {
            throw new NotImplementedException();
        }

        public OsobaModel IzradiOsobu(OsobaModel model)
        {
            List<OsobaModel> osoba = OsobaFile.FullFilePath().LoadFile().ConvertToOsobaModels();

            int currentID = 1;

            if(osoba.Count > 0)
            {
                currentID = osoba.OrderByDescending(x => x.ID).First().ID + 1;
            }
            model.ID = currentID;

            osoba.Add(model);

            osoba.SaveToOsobaFile(OsobaFile);

            return model;
        }

        public NagradaModel NapraviNagradu(NagradaModel model)
        {
            // load the text file convert the text to List<NagradaModel>
            List<NagradaModel> nagrade = NagradaFile.FullFilePath().LoadFile().ConvertToNagradaModels();
            //find the max ID
            int currentId = 1;

            if (nagrade.Count > 0)
            {
                currentId = nagrade.OrderByDescending(x => x.ID).First().ID + 1; 
            }
            model.ID = currentId;
            // Add the new record with the new ID (max + 1)
            nagrade.Add(model);


            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            nagrade.SaveToPrizeFile(NagradaFile);

            return model;
        }
        public List<OsobaModel> GetPeople_All()
        {
            return OsobaFile.FullFilePath().LoadFile().ConvertToOsobaModels();
        }

        public EkipaModel IzradiEkipu(EkipaModel model)
        {
            List<EkipaModel> ekipe = EkipaFile.FullFilePath().LoadFile().ConvertToEkipaModels(OsobaFile);

            int currentID = 1;

            if (ekipe.Count > 0)
            {
                currentID = ekipe.OrderByDescending(x => x.ID).First().ID + 1;
            }
            model.ID = currentID;

            ekipe.Add(model);

            ekipe.SaveToEkipaFile(EkipaFile);

            return model;
        }

        public List<EkipaModel> GetEkipa_All()
        {
            throw new NotImplementedException();
        }

        public TurnirModel KreiranjeTurnira(TurnirModel model)
        {
            List<TurnirModel> turniri = TurnirFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTurnirModels(EkipaFile, OsobaFile, NagradaFile);

            int currentID = 1;

            if (turniri.Count > 0)
            {
                currentID = turniri.OrderByDescending(x => x.ID).First().ID + 1;
            }
            model.ID = currentID;
            turniri.Add(model);

            turniri.SaveToTurnirFile();
        }
    }
}
