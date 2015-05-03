using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Config {
    using CheesecakeCardBuilder.Properties;
    using Newtonsoft.Json;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Runtime.InteropServices;

    public class ProjectConfig {
        private readonly String carteUnit = "cartes/unit.png";

        [JsonIgnore]
        private GlobalConfig globalConfig;
        public readonly Font topStatsFont, statsFont, descriptionFont, keywordFont, nameFont;
        public readonly List<String> keywords = new List<String>() { "Long-Range", "Ranged", "Waller", "Flying" };

        public ProjectConfig(GlobalConfig globalConfig) {
            topStatsFont = new Font("Segoe Script", 10f, FontStyle.Regular);
            statsFont = new Font("Vijaya", 20f, FontStyle.Regular);
            descriptionFont = new Font("Vijaya", 11f, FontStyle.Regular);
            nameFont = new Font("Segoe Script", 10f, FontStyle.Regular);
            keywordFont = new Font("Segoe Script", 9.5f, FontStyle.Regular);
            setGlobalConfig(globalConfig);
        }

        public void setGlobalConfig(GlobalConfig globalConfig) {
            this.globalConfig = globalConfig;
        }

        public String getUnitPath() {
            return globalConfig.projectPath + "/" + carteUnit;
        }
    }
}
