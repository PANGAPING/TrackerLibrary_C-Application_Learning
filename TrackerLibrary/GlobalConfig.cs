using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public const string PrizesFile = "PrizeModels.csv";
        public const string PersonsFile = "PersonModels.csv";
        public const string TeamsFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get;private set; }

        public static void InitializeConnections(DatabaseType databaseType)
        {
            if(databaseType == DatabaseType.Sql)
            {
                //TODO - Create the SQL Connection
                SqlConnection sql = new SqlConnection();
                Connection = sql;
            }

            if (databaseType == DatabaseType.TextFile)
             {
                //TODO - Create the Text Connection
                TextConnection text = new TextConnection();
                Connection = text;
            }
        }

        public static string CnnString(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
