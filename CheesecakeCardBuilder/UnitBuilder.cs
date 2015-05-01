using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheesecakeCardBuilder {
    using Config;

    public partial class UnitBuilder : Form {
        private ProjectConfig config;
        public UnitBuilder(ProjectConfig config) {
            this.config = config;
            InitializeComponent();
        }
    }
}
