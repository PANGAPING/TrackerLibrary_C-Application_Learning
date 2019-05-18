using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }

        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Just for sql query.
        /// </summary>
        public int WinnerId { get; set; }

        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }


        public string DisPlayName {
            get
            {
                string output = "";

                foreach (MatchupEntryModel entry in Entries) {
                    if (entry.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = entry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {entry.TeamCompeting.TeamName}";
                        }
                    }
                    else {
                        output = "Matchup Not Yet Determined.";

                        break;
                    }
                }


                return output;
            }
        }
    }
}
