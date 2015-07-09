﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder.Builders {
    using Config;
    using Repository;
    using CheesecakeCardBuilder.Unit;
    using CheesecakeCardBuilder.Structure;

    public partial class CardLoader : Form {
        private Dictionary<string, TypeLoader> typeLoaders = new Dictionary<string, TypeLoader>();
        public bool hasSelected {
            get {
                return selectedCard != null;
            }
        }
        public Card selectedCard { get; private set; }

        public CardLoader(CardRepository repository) {
            InitializeComponent();
            forceResize();
            typeLoaders.Add("Units", new AnyTypeLoader<UnitCard>(repository.getAllUnitCards(), this));
            typeLoaders.Add("Structures", new AnyTypeLoader<StructureCard>(repository.getAllStructureCards(), this));
            typeLoaders.Add("Casters", new AnyTypeLoader<CasterCard>(repository.getAllCasterCards(), this));
        }

        private void CardLoader_Load(object sender, EventArgs e) {
            foreach (string key in typeLoaders.Keys) {
                TypeLoader typeLoader = typeLoaders[key];
                TabPage page = new TabPage(key);
                page.Controls.Add((UserControl)typeLoader);
                loadTabs.TabPages.Add(page);
            }
        }

        public void finish(Card card) {
            if (card != null) {
                selectedCard = card;
                this.Close();
            }
        }

        private void loadTabs_SizeChanged(object sender, EventArgs e) {
            forceResize();
        }

        private void forceResize() {
            foreach (UserControl control in typeLoaders.Values) {
                control.Size = new Size(loadTabs.Size.Width - 50, loadTabs.Size.Height - 50);
            }
        }
    }
}
