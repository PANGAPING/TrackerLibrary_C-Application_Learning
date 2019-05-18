using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnection : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonsFile = "PersonModels.csv";
        private const string TeamsFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";

        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = PersonsFile.FullFilePath().loadFile().ConvertToPersonModels();

            int currentId = 1;
            if (persons.Count > 0) {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            persons.Add(model);
            persons.SaveToPersonFile(PersonsFile);

        }

        public void CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().loadFile().ConvertToPrizeModels();

            int currentId = 1;

            if (prizes.Count > 0) {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }


            model.Id = currentId;

            prizes.Add(model);
            prizes.SaveToPrizeFile(PrizesFile);




        }

        public List<PersonModel> GetAllPersons()
        {
            return PersonsFile.FullFilePath().loadFile().ConvertToPersonModels();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamsFile.FullFilePath().loadFile().ConvertToTeamModels(TeamsFile);

            int currentId = 1;
            if(teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamsFile);

            
        }

        public List<TeamModel> GetAllTeams()
        {
            return TeamsFile.FullFilePath().loadFile().ConvertToTeamModels(TeamsFile);
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().loadFile().ConvertToTournamentModels(TeamsFile,PersonsFile,PrizesFile);

            int currentId = 1;

            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;     
            }

            model.Id = currentId;

            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);

        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamentFile.FullFilePath().loadFile().ConvertToTournamentModels(TeamsFile, PersonsFile, PrizesFile);
        }

        public void UpdateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }
    }
}
