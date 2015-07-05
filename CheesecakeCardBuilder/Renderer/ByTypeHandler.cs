using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CheesecakeCardBuilder.Unit;
    public class ByTypeHandler<Value> {
        private Dictionary<UnitType, Value> list = new Dictionary<UnitType, Value>();
        private Value defaultValue;
        private bool hasDefaultValue;

        public ByTypeHandler(){

        }

        public ByTypeHandler(Value defaultValue) {
            this.defaultValue = defaultValue;
            hasDefaultValue = true;
        }

        public void Add(UnitType type, Value value) {
            list.Add(type, value);
        }

        public Value Get(UnitType type) {
            if (list.ContainsKey(type)) {
                return list[type];
            } else if (hasDefaultValue) {
                return defaultValue;
            } else {
                throw new NotSupportedException();
            }
        }
    }
}
