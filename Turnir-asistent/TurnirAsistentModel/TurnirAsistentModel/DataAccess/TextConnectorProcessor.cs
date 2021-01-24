using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel.Models;

// * load the text file
// * convert the text to List<NagradaModel>
// find the max ID
// Add the new record with the new ID (max + 1)
// Convert the prizes to list<string>
// Save the list<string> to the text file

namespace TurnirAsistentModel.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) 
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file) == false)
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<NagradaModel> ConvertToNagradaModels(this List<string> lines)
        {
            List<NagradaModel> output = new List<NagradaModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                NagradaModel p = new NagradaModel();
                p.ID = int.Parse(cols[0]);
                p.Mjesto = int.Parse(cols[1]);
                p.NazivMjesta = cols[2];
                p.IznosNagrade = decimal.Parse(cols[3]);
                p.PostotakNagrade = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;

            
        }

        public static List<OsobaModel> ConvertToOsobaModels(this List<string> lines)
        {
            List<OsobaModel> output = new List<OsobaModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                OsobaModel p = new OsobaModel();
                p.ID = int.Parse(cols[0]);
                p.Ime = cols[1];
                p.Prezime = cols[2];
                p.EmailAdresa = cols[3];
                p.BrojMobitela = cols[4];
                output.Add(p);

            }
            return output;

        }
        public static List<EkipaModel> ConvertToEkipaModels(this List<string> lines, string osobaFileName)
        {
            //id, ime ekipe, list of ids seperated by the pipe
            //3, Tim's Team,1|3|5
            List<EkipaModel> output = new List<EkipaModel>();
            List<OsobaModel> osoba = osobaFileName.FullFilePath().LoadFile().ConvertToOsobaModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                EkipaModel t = new EkipaModel();
                t.ID = int.Parse(cols[0]);
                t.ImeEkipe = cols[1];

                string[] osobaIDs = cols[2].Split('|');

                foreach (string ID in osobaIDs)
                {                                                       
                    t.ClanoviEkipe.Add(osoba.Where(x => x.ID == int.Parse(ID)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TurnirModel> ConvertToTurnirModels(
            this List<string> lines,
            string EkipaFileNaziv,
            string osobaFileName,
            string NagradaFileNaziv
            )
        {
            List<TurnirModel> output = new List<TurnirModel>();
            List<EkipaModel> ekipe = EkipaFileNaziv.FullFilePath().LoadFile().ConvertToEkipaModels(osobaFileName);
            List<NagradaModel> nagrade = NagradaFileNaziv.FullFilePath().LoadFile().ConvertToNagradaModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TurnirModel tm = new TurnirModel();
                tm.ID = int.Parse(cols[0]);
                tm.NazivTurnira = cols[1];
                tm.Kotizacija = decimal.Parse(cols[2]);

                string[] EkipaIDs = cols[3].Split('|');
                foreach (string ID in EkipaIDs)
                {
                    tm.PrijavljeniTimovi.Add(ekipe.Where(x => x.ID == int.Parse(ID)).First());
                }
                string[] NagradaIDs = cols[4].Split('|');
                foreach(string ID in NagradaIDs)
                {
                    tm.Nagrade.Add(nagrade.Where(x => x.ID == int.Parse(ID)).First());
                }
                output.Add(tm);
            }
            return output;
        }

        public static void SaveToNagradaFile(this List<NagradaModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (NagradaModel p in models)
            {
                lines.Add($"{ p.ID },{ p.Mjesto },{ p.NazivMjesta },{ p.IznosNagrade },{ p.PostotakNagrade }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToOsobaFile(this List<OsobaModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(OsobaModel p in models)
            {
                lines.Add($"{p.ID },{ p.Ime },{ p.Prezime },{ p.EmailAdresa },{p.BrojMobitela }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToEkipaFile(this List<EkipaModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (EkipaModel t in models)
            {
                lines.Add($"{ t.ID },{ t.ImeEkipe },{ ConvertOsobaListToString(t.ClanoviEkipe) }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTurnirFile(this List<TurnirModel> models)
        {
            List<string> lines = new List<string>();
            foreach(TurnirModel tm in models)
            {
                lines.Add($@"{ tm.ID },
                { tm.NazivTurnira },
                { tm.Kotizacija }, 
                { ConvertEkipaListToString(tm.PrijavljeniTimovi) },
                { ConvertNagradaListToString(tm.Nagrade) },
                { ConvertUtakmicaListToString(tm.Runde) } ");
            }
        }

        private static object ConvertUtakmicaListToString(List<List<UtakmicaModel>> runde)
        {
            throw new NotImplementedException();
        }

        private static string ConvertUtakmicaListToString(List<UtakmicaModel> utakmice)
        {
            string output = "";

            if (utakmice.Count == 0)
            {
                return "";
            }

            foreach (List<UtakmicaModel> r in utakmice)
            {
                output += $"{ ConvertUtakmicaListToString(r)   }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

            
        private static string ConvertNagradaListToString(List<NagradaModel> nagrade)
        {
            string output = "";

            if (nagrade.Count == 0)
            {
                return "";
            }

            foreach (NagradaModel p in nagrade)
            {
                output += $"{ p.ID }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertEkipaListToString(List<EkipaModel> ekipe)
        {
            string output = "";

            if (ekipe.Count == 0)
            {
                return "";
            }

            foreach (EkipaModel p in ekipe)
            {
                output += $"{ p.ID }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertOsobaListToString(List<OsobaModel> osobe)
        {
            string output = "";

            if (osobe.Count == 0)
            {
                return "";
            }
            
            foreach (OsobaModel p in osobe)
            {
                output += $"{ p.ID }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
