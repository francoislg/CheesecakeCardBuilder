﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheesecakeCardBuilder.Config;

namespace CheesecakeCardBuilder.Builders.Description {
    using Description;
    using CheesecakeCardBuilder.Description;
    public partial class OpenDescriptionControl : UserControl, DescriptionControl {
        private CardUpdater updater;
        private DefaultDescription unitDesc;

        public String name {
            get {
                return unitDesc.name;
            }
        }

        public DescriptionType typeDescription {
            get {
                return unitDesc.type;
            }
        }

        public CardDescription cardDescription {
            get {
                return unitDesc;
            }
            set {
                unitDesc.description = value.description;
                if (value.description.Count() > 0) {
                    descTextBox.Text = value.description[1];
                }
            }
        }

        public OpenDescriptionControl(ProjectConfig config, CardUpdater updater) {
            InitializeComponent();
            this.unitDesc = new DefaultDescription();
            this.updater = updater;
        }

        public void clear() {
            descTextBox.Text = "";
        }

        private void descTextBox_TextChanged(object sender, EventArgs e) {
            cardDescription.description = new String[] { String.IsNullOrEmpty(descTextBox.Text) ? "" : "Special :", descTextBox.Text };
            updater.updateCard();
        }
    }
}
