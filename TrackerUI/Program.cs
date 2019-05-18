using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);


            Application.Run(new CreateTeamForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
