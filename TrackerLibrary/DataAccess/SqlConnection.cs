using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


//@placenumber int,
//@placename nvarchar(50),
//@prizeamount money,
//@prizepercentage float,
//@id int = 0 output

namespace TrackerLibrary.DataAccess
{
    public class SqlConnection : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellPhoneNumber", model.CellPhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPersons_insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");



            }
        }

        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) {
                var p =new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_insert",p,commandType : CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");


            }
        }

        public void CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                model.Id = p.Get<int>("@id");

                connection.Execute("dbo.spTeams_insert", p, commandType: CommandType.StoredProcedure);

                foreach (PersonModel person in model.TeamMembers) {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", person.Id);
                    connection.Execute("dbo.spTeamMembers_insert",p,commandType: CommandType.StoredProcedure);
                }



            }

        }

        public void CreateTournament(TournamentModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                SaveTournament(connection, model);

                SaveTournamentPrizes(connection, model);

                SaveTournamentEntryFees(connection, model);

                SaveTournamentRounds(connection,model);
            }

        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model) {

            // List<List<MatchupModel>> Rounds
            // List<MatchupEntryModel> Matchup

            //Loop through the rounds
            //Loop through the matchups
            //Save the matchup
            //Loop through the entries and asve them

            foreach (List<MatchupModel> round in model.Rounds) {
                foreach (MatchupModel matchup in round) {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("spMatchups_Insert", p, commandType: CommandType.StoredProcedure);
                    
                    matchup.Id = p.Get<int>("@id");

                    foreach (MatchupEntryModel matchupEntry in matchup.Entries) {
                        p = new DynamicParameters();


                        //@matchupid int,
                        //@parentmatchupid int,
                        //@teamcompetingid int,
                        //@id int = 0 output


                        p.Add("@MatchupId", matchup.Id);

                        if (matchupEntry.ParentMatchup == null)
                        {

                            p.Add("@ParentMatchupid", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupid", matchupEntry.ParentMatchup.Id);
                        }





                        if (matchupEntry.TeamCompeting == null)
                        {

                            p.Add("@TeamCompetingId", null);
                        }
                        else {
                            p.Add("@TeamCompetingid", matchupEntry.TeamCompeting.Id);
                        }




                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

                        matchupEntry.Id = p.Get<int>("@id");

                    }
                }
            }

        }

        private void SaveTournament(IDbConnection connection,TournamentModel model) {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            foreach (PrizeModel pz in model.Prizes)
            {
                p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            }
        }

        private void SaveTournamentEntryFees(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            foreach (TeamModel tm in model.EnteredTeams)
            {

                p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntires_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }



        public List<PersonModel> GetAllPersons()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_getAll").ToList();
                return output;
            }

        }

        public List<TeamModel> GetAllTeams()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_getAll").ToList();

                foreach (TeamModel team in output) {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",p,commandType: CommandType.StoredProcedure).ToList();
                }
            }


            return output;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

                foreach (TournamentModel t in output) {

                    var p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);

                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_getByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in t.EnteredTeams) {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();  
                    }


                    foreach(MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();

                        p.Add("@MatchupId", m.Id);

                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();
                        //Populate each entry


                        List<TeamModel> allTeams = GetAllTeams();


                        if (m.WinnerId > 0) {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }

                        foreach (var me in m.Entries) {
                            if (me.TeamCompetingId > 0) {
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }
                            if (me.ParentMatchupId > 0) {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
                            }
                        }
                    }



                    //For matchupmodel we get in databases is ordered by roundId
                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;
                    foreach (MatchupModel m in matchups) {
                        if (m.MatchupRound > currRound) {
                            t.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound += 1;
                        }
                        currRow.Add(m);
                    }

                    t.Rounds.Add(currRow);

                }




                //Populate Prizes

                //Populate Teams

                //Populate Rounds
            }


                return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {

            //spMatchups_Update @id, @WinnerId
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament"))) {
                var p = new DynamicParameters();

                if (model.Winner != null) {
                    p.Add("@id", model.Id);
                    p.Add("@WinnerId", model.Winner.Id);

                    connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                }


                //spMatchupEntries_Update id,TeamCompetingId,Score

                foreach (MatchupEntryModel me in model.Entries) {
                    if (me.TeamCompeting != null) {
                        p = new DynamicParameters();
                        p.Add("@id", me.Id);
                        p.Add("@TeamCompeting", me.TeamCompeting.Id);
                        p.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);

                    }

                }

            }
        }
    }
}
