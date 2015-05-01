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
