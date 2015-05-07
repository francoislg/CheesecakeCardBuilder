using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class DefaultUnitDescription : UnitDescription {
        public UnitDescriptionType type {
            get {
                return UnitDescriptionType.Default;
            }
        }
        private String when;
        private String target;
        private String action;

        public String name { get { return "Default"; } }
        public String[] description {
            get {
                return new String[] { when + ",", target, action };
            }
            set {
                when = value[0];
                target = value[1];
                action = value[2];
            }
        }
    }
}
