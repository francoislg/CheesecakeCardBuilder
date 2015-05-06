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

        public String unitPath {
            get {
                return globalConfig.projectPath + "/cartes/unit.png";
            }
        }
        public String iconAtkPath {
            get {
                return globalConfig.projectPath + "/icones/atk.png";
            }
        }
        public String iconDefPath {
            get {
                return globalConfig.projectPath + "/icones/def.png";
            }
        }

        [JsonIgnore]
        private GlobalConfig globalConfig;
        public readonly Font topStatsFont, statsFont, descriptionFont, keywordFont, nameFont;
        public readonly List<String> keywords = new List<String>() { "Long-Range", "Ranged", "Waller", "Flying" };

        public ProjectConfig(GlobalConfig globalConfig) {
            topStatsFont = new Font("Segoe Script", pointsToEm(14f), FontStyle.Regular);
            statsFont = new Font("Vijaya", pointsToEm(20f), FontStyle.Regular);
            descriptionFont = new Font("Vijaya", pointsToEm(11f), FontStyle.Regular);
            nameFont = new Font("Segoe Script", pointsToEm(10f), FontStyle.Regular);
            keywordFont = new Font("Segoe Script", pointsToEm(9.5f), FontStyle.Regular);
            setGlobalConfig(globalConfig);
        }

        public void setGlobalConfig(GlobalConfig globalConfig) {
            this.globalConfig = globalConfig;
        }

        private float pointsToEm(float points) {
            return points * 3;
        }
    }
}
