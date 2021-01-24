using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel.Models;

//@PlaceNumber int,
//	@PlaceName nvarchar(30),
//	@PrizeAmount money,
//    @PrizePercentage float,
//	@id int = 0 output

namespace TurnirAsistentModel.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "TurnirAsisstent";
        private List<OsobaModel> output;

        public List<OsobaModel> GetOsoba_All()
        {
            throw new NotImplementedException();
        }

        public OsobaModel IzradiOsobu(OsobaModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Ime", model.Ime);
                p.Add("@Prezime", model.Prezime);
                p.Add("@EmailAdresa", model.EmailAdresa);
                p.Add("@BrojMobitela", model.BrojMobitela);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople1_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;

            }
        }

        // TODO - Izradi NapraviNagradu metodu koju sacuva u bazu
        /// <summary>
        /// spremi novu nagradu u bazu podataka
        /// </summary>
        /// <param name="model">info o nagradama</param>
        /// <returns>info o nagradama, ukljucujuci posebni indetifikator</returns>
        public NagradaModel NapraviNagradu(NagradaModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Mjesto", model.Mjesto);
                p.Add("@NazivMjesta", model.NazivMjesta);
                p.Add("@IznosNagrade", model.IznosNagrade);
                p.Add("@PostotakNagrade", model.PostotakNagrade);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                
                model.ID = p.Get<int>("@id");

                return model;

            }
        }

        public List<OsobaModel> GetPeople1_All()
        {
            List<OsobaModel> output;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<OsobaModel>("dbo.spPeople1_GetAll").ToList();
            }

            return output;
        }

        public EkipaModel IzradiEkipu(EkipaModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ImeEkipe", model.ImeEkipe);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                foreach (OsobaModel tm in model.ImeEkipe)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.ID);
                    p.Add("@Persond", tm.ID);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return model;

            }
        }

        public List<OsobaModel> GetPeople_All()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<OsobaModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }

        public List<EkipaModel> GetEkipa_All()
        {
            List<EkipaModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<EkipaModel>("dbo.spTeam_GetAll").ToList();

                foreach (EkipaModel ekipa in output)
                {
                    ekipa.ClanoviEkipe = connection.Query<OsobaModel>("dbo.spTeamMembers_GetByTeam").ToList();
                }
            }
            return output;
        }

        public TurnirModel KreiranjeTurnira(TurnirModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SpremiTurnir(connection, model);
                SpremiTurnirNagrade(connection, model);
                SpremiTurnirPrijavljeni(connection, model);

                

               
                return model;
            }
        }
        private void SpremiTurnir(IDbConnection connection, TurnirModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TurnirModel", model.NazivTurnira);
            p.Add("@Kotizacija", model.Kotizacija);
            p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.ID = p.Get<int>("@id");
        }
        private void SpremiTurnirNagrade(IDbConnection connection, TurnirModel model)
        {
            foreach (NagradaModel pz in model.Nagrade)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.ID);
                p.Add("@PrizeId", pz.ID);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SpremiTurnirPrijavljeni(IDbConnection connection, TurnirModel model)
        {
            foreach (EkipaModel tm in model.PrijavljeniTimovi)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.ID);
                p.Add("@TeamId", tm.ID);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
