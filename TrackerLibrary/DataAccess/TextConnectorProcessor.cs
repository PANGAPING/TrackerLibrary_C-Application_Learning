using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }

        public static List<string> loadFile(this string file) {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines) {

            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines) {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {

            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }


        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName) {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> persons = peopleFileName.FullFilePath().loadFile().ConvertToPersonModels();

            foreach (string line in lines) {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];
                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds) {
                    t.TeamMembers.Add(persons.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);

            }
            return output;
        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile) {

            foreach (List<MatchupModel> round in model.Rounds) {
                foreach (MatchupModel matchup in round) {
                    matchup.SaveMatchupToFile(matchupFile);
                }
            }
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName) {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models) {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }


        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName) {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models) {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName, lines);
        }

        public static void SaveToTournamentFile(this TournamentModel model, string matchupFile, string matchupEntryFile) {
            //Loop through each Round
            //loop through each matchup
            //Get the id for the new matchup and save the record
            //Loop through each Entry,get the id, and save it.

            foreach (List<MatchupModel> round in model.Rounds) {
                foreach (MatchupModel matchup in round) {
                    //Load all of the matchups from file
                    //Get the top id and add one
                    //Store the id 
                    //Save the matchup record
                    matchup.SaveMatchupToFile(matchupFile);

                    foreach (MatchupEntryModel entry in matchup.Entries) {
                        entry.SaveEntryToFile(matchupEntryFile);
                    }
                }
            }
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input) {
            string[] ids = input.Split('|');

            List<MatchupEntryModel> output;
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().loadFile();
            List<string> matchingEntries = new List<string>();


            foreach (string id in ids) {
                foreach (string entry in entries) {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id) {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.CovertToMatchupEntryModels();

            return output;
        }


        public static List<MatchupEntryModel> CovertToMatchupEntryModels(this List<string> lines) {

            // id = 0,TeamCompeting = 1,Score = 2, ParentMatchup = 3
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines) {
                string[] cols = line.Split(',');

                MatchupEntryModel m = new MatchupEntryModel();
                m.Id = int.Parse(cols[0]);

                if (cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else {
                    m.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }



                m.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    m.ParentMatchup = LookupMatchupById(parentId);
                }
                else {
                    m.ParentMatchup = null;
                }

                output.Add(m);

            }

            return output;
        }

        private static MatchupModel LookupMatchupById(int id) {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().loadFile();

            foreach (string matchup in matchups) {
                string[] cols = matchup.Split(',');

                if (cols[0] == id.ToString()) {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }

            return null;
        }


        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamsFile.FullFilePath().loadFile();

            foreach (string team in teams) {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString()) {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels(GlobalConfig.PersonsFile).First();
                }
            }


            return null;
        }



        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            //id=0,entries=1(pipe delimited by id),  winner =2, metchupRound = 3
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                if (cols[2].Length == 0)
                {
                    p.Winner = null;
                }
                else {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));
                }

                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);
            }

            return output;
        }


        public static void SaveEntryToFile(this MatchupEntryModel matchupEntry, string matchupEntryFile) {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().loadFile().CovertToMatchupEntryModels();

            int currentId = 1;
            if (entries.Count > 0) {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchupEntry.Id = currentId;
            entries.Add(matchupEntry);

            //save to file
            List<string> lines = new List<string>();
            //id = 0, TeamXompeting = 1,Score = 2, ParentMatchup =3

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null) {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null) {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void UpdateEntryToFile(this MatchupEntryModel entry) {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().loadFile().CovertToMatchupEntryModels();

            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach (MatchupEntryModel me in entries) {
                if(me.Id == entry.Id)
                {
                    oldEntry = me;
                }
            }


            entries.Remove(oldEntry);

            entries.Add(entry);

            //save to file
            List<string> lines = new List<string>();
            //id = 0, TeamXompeting = 1,Score = 2, ParentMatchup =3

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }



        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFile) {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().loadFile().ConvertToMatchupModels();

            int currentId = 1;
            if (matchups.Count > 0) {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            matchups.Add(matchup);



            foreach (MatchupEntryModel  entry in matchup.Entries) {

                entry.SaveEntryToFile(GlobalConfig.MatchupEntryFile);

            }

            //save the file
            List<string> lines = new List<string>();
            //id = 0, entries = 1(piep delimited by id),winner = 2,matchupRound = 3

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null) {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{m.Id},{CovertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }


        public static void UpdateMatchupToFile(this MatchupModel matchup) {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().loadFile().ConvertToMatchupModels();

            MatchupModel oldMatchup = new MatchupModel();

            foreach (MatchupModel m in matchups) {
                if (m.Id == matchup.Id) {
                    oldMatchup = m;
                }
            }

            matchups.Remove(oldMatchup);
            matchups.Add(matchup);



            foreach (MatchupEntryModel entry in matchup.Entries)
            {

                entry.UpdateEntryToFile();

            }

            //save the file
            List<string> lines = new List<string>();
            //id = 0, entries = 1(piep delimited by id),winner = 2,matchupRound = 3

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{m.Id},{CovertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);


        }

        

        private static string CovertMatchupEntryListToString(List<MatchupEntryModel> entries) {
            string output = "";

            if (entries.Count == 0) {
                return "";
            }

            foreach (MatchupEntryModel e in entries) {
                output += $"{e.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;

        }


        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName) {

            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models) {

                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertTeamListToString(tm.EnteredTeams)},{ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds) {
            //rounds string like (id^id^id|id^id)

            string output = "";
            if (rounds.Count == 0) {
                return output;
            }

            foreach (List<MatchupModel> r in rounds) {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return output;
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }

            return output.Substring(0, output.Length - 1);

        }


        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return output;
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }

            return output.Substring(0, output.Length - 1);

        }

        private static string ConvertTeamListToString(List<TeamModel> teams) {
            string output = "";

            if (teams.Count == 0)
            {
                return output;
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }

            return output.Substring(0, output.Length - 1);

        }

        private static string ConvertPeopleListToString(List<PersonModel> peoples)
        {
            string output = "";

            if (peoples.Count == 0) {
                return output;
            }

            foreach (PersonModel p in peoples) {
                output += $"{p.Id}|";
            }

            return output.Substring(0, output.Length - 1);     
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines,
            string teamFileName,
            string peopleFileName,
            string prizeFileName) {

            // id = 0
            // TournamentName = 1
            // EntryFee = 2
            // EnterTeams = 3
            // Prizes = 4
            // Rounds = 5


            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().loadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().loadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().loadFile().ConvertToMatchupModels();

            foreach (string line in lines) {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds) {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }


                if (cols[4].Length > 0) {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }

                }


                // Captrue Rounds information
                string[] rounds = cols[5].Split('|');
                List<MatchupModel> ms = new List<MatchupModel>();

                foreach (string round in rounds) {
                    string[] mIds = round.Split('^');
                    foreach(string mId in mIds) {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(mId)).First());
                    }
                    tm.Rounds.Add(ms);
                    ms = new List<MatchupModel>();
                }



                output.Add(tm);
            }

            return output;
        }
    }
}
