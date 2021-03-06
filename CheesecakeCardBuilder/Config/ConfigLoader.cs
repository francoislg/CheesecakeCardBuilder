﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Config {
    using Newtonsoft.Json;
    using System.Windows.Forms;
    class ConfigLoader {
        private readonly String projectConfigFile = "project.config";

        private GlobalConfig globalConfig;
        private ProjectConfig projectConfig;

        public ConfigLoader(String globalConfigPath) {
            if (File.Exists(globalConfigPath)) {
                globalConfig = DeserializeFile<GlobalConfig>(globalConfigPath);
                checkProjectConfig(globalConfig.projectPath);
            }else{
                globalConfig = new GlobalConfig();
                writeFirstConfig(globalConfigPath);
            }
        }

        private void checkProjectConfig(String projectConfigPath) {
            String projectConfigFileFullPath = globalConfig.projectPath + "/" + projectConfigFile;
            if (File.Exists(projectConfigFileFullPath)) {
                projectConfig = DeserializeFile<ProjectConfig>(projectConfigFileFullPath);
                projectConfig.globalConfig = globalConfig;
            } else {
                projectConfig = new ProjectConfig(globalConfig);
                writeFirstConfigInProjectFolder(projectConfigFileFullPath);
            }
        }

        private void writeFirstConfig(String globalConfigPath) {
            globalConfig.projectPath = getFolderPath();
            writeToFile<GlobalConfig>(globalConfigPath, globalConfig);
            checkProjectConfig(globalConfig.projectPath);
        }

        private void writeFirstConfigInProjectFolder(String projectConfigPath) {
            createSubFolders();
            // Tmp so that global config won't be save in the project config...
            GlobalConfig tmpConfig = projectConfig.globalConfig;
            projectConfig.globalConfig = new GlobalConfig() { projectPath = "" };
            writeToFile<ProjectConfig>(projectConfigPath, projectConfig);
            projectConfig.globalConfig = tmpConfig;
        }

        private void createSubFolders() {
            createSubFolder(globalConfig.projectPath + "/cartes");
        }

        private void createSubFolder(String folder) {
            if (!Directory.Exists(folder)) {
                Directory.CreateDirectory(folder);
            }
        }

        private String getFolderPath() {
            using (FolderBrowserDialog pathSelector = new FolderBrowserDialog()) {
                pathSelector.RootFolder = Environment.SpecialFolder.MyDocuments;
                if (pathSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    return pathSelector.SelectedPath;
                } else {
                    throw new InvalidDataException();
                }
            }
        }

        private String getFilePath(String title, String ext) {
            using (OpenFileDialog fileSelector = new OpenFileDialog()) {
                fileSelector.Title = title;
                fileSelector.DefaultExt = ext;
                if (fileSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    return fileSelector.FileName;
                } else {
                    throw new InvalidDataException();
                }
            }
        }

        private void writeToFile<T>(String path, T obj) {
            String json = JsonConvert.SerializeObject(obj);
            using (StreamWriter sr = new StreamWriter(path)) {
                sr.Write(json);
            }
        }

        private T DeserializeFile<T>(String file) {
            using(StreamReader sr = new StreamReader(file)){
                String text = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(text);
            }
        }

        public ProjectConfig getConfig() {
            return projectConfig;
        }
    }
}
