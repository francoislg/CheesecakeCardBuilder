using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    public class KeywordUnitDescription : UnitDescription {
        public UnitDescriptionType type {
            get {
                return UnitDescriptionType.Keyword;
            }
        }
        public String name { get { return "Keyword"; } }
        private String keyword;
        public String[] description {
            get {
                return new String[] { keyword };
            }
            set {
                keyword = value[0];
            }
        }
    }
}
