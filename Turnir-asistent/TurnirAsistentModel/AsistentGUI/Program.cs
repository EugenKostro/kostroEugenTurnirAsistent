using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnirAsistentModel;

namespace AsistentGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the database connections
            TurnirAsistentModel.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new DodavanjeEkipe());

            //Application.Run(new PregledTurnira());
        }
    }
}
