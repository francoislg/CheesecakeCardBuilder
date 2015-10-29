using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder {
    using Config;
    using CheesecakeCardBuilder.Builders;

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            defaultAppConfig();

            String myDocumentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String configFile = "CheesecakeCardBuilder.config";
            ConfigLoader loader = new ConfigLoader(myDocumentPath + "\\" + configFile);

            Application.Run(new CardBuilder(loader.getConfig()));
        }

        private static void defaultAppConfig() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}
