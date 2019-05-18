using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //TODO - Wire our matchups
        //Order our list randomly of teams
        //Check if it is big enough - if not,add in byes
        //Create our fierst round of matchups
        //Create every round after that




        private static int ChenkCurrentRound(this TournamentModel model) {
            int output = 1;
            foreach (List<MatchupModel> round in model.Rounds) {
                if (round.All(x => x.Winner != null)) {
                    output += 1;
                }
            }

            return output;
        }

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizeTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizeTeams.Count);
            int byes = NumberOfByes(rounds, randomizeTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizeTeams));

            CreateOtherRounds(model, rounds);

        }

        private static void CreateOtherRounds(TournamentModel model,int rounds) {

            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds) {
                foreach (MatchupModel match in previousRound) {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1) {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<MatchupModel>();
                round += 1;
            }

        }


        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams) {

            List<MatchupModel> output = new List<MatchupModel>();

            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams) {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1) {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0) {
                        byes -= 1;
                    }
                }        
            }

            return output;

        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;

            int totalTeams = (int)Math.Pow(2, rounds);
            output = totalTeams - numberOfTeams;

            return output;
        }


        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 0;
            int val = 2;

            while (val < teamCount)
            {
                //output = output  + 1
                output += 1;

                //val = val * 2
                val *= 2;
            }

            return output;
        }



        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
