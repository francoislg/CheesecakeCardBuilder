using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Config {
    using Newtonsoft.Json;

    public class ProjectConfig {
        private readonly String carteUnit = "cartes/unit.png";

        [JsonIgnore]
        private GlobalConfig globalConfig;
        public readonly String topStatsFont = "Segoe Script";
        public readonly float topStatsFontSize = 20f;
        public readonly String statsFont = "Vijaya";
        public readonly float statsFontSize = 20f;
        public readonly String descriptionFont = "Segoe Script";
        public readonly float descriptionFontSize = 8f;
        public readonly String nameFont = "Segoe Script";
        public readonly float nameFontSize = 10f;

        public ProjectConfig(GlobalConfig globalConfig) {
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
