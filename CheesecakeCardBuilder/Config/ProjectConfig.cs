﻿using System;
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

        public String iconsPath {
            get {
                return globalConfig.projectPath + "\\icones";
            }
        }
        public String cardsPath {
            get {
                return globalConfig.projectPath + "\\cartes";
            }
        }
        public String cardsArtPath {
            get {
                return cardsPath + "\\art";
            }
        }

        public String unitFile {
            get {
                return cardsPath + "\\unit.png";
            }
        }
        public String iconAtkFile {
            get {
                return iconsPath + "\\atk.png";
            }
        }
        public String iconDefFile {
            get {
                return iconsPath + "\\def.png";
            }
        }
        public String iconAccFile {
            get {
                return iconsPath + "\\acc.png";
            }
        }
        public String iconSpdFile {
            get {
                return iconsPath + "\\spd.png";
            }
        }
        public String iconHPFile {
            get {
                return iconsPath + "\\hp.png";
            }
        }
        public String iconResFile {
            get {
                return iconsPath + "\\res.png";
            }
        }
        public String background1File {
            get {
                return cardsPath + "\\bg1.png";
            }
        }
        public String background2File {
            get {
                return cardsPath + "\\bg2.png";
            }
        }
        public String background3File {
            get {
                return cardsPath + "\\bg3.png";
            }
        }
        public String background4File {
            get {
                return cardsPath + "\\bg4.png";
            }
        }
        public String background5File {
            get {
                return cardsPath + "\\bg5.png";
            }
        }
        public String databaseFile {
            get {
                return globalConfig.projectPath + "\\database.db";
            }
        }

        [JsonIgnore]
        private GlobalConfig globalConfig;
        public readonly Font topStatsFont, statsFont, descriptionFont, keywordFont, nameFont;
        public readonly List<String> keywords = new List<string>();

        public ProjectConfig(GlobalConfig globalConfig) {
            topStatsFont = new Font("Segoe Script", pointsToEm(14f), FontStyle.Regular);
            statsFont = new Font("Vijaya", pointsToEm(20f), FontStyle.Regular);
            descriptionFont = new Font("Vijaya", pointsToEm(11f), FontStyle.Bold);
            nameFont = new Font("Vijaya", pointsToEm(13f), FontStyle.Regular);
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
