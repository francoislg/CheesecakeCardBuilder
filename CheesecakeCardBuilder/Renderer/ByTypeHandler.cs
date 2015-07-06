using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using CheesecakeCardBuilder.Unit;
    public class ByTypeHandler<Type, Value> {
        private Dictionary<Type, Value> list = new Dictionary<Type, Value>();
        private Value defaultValue;
        private bool hasDefaultValue;

        public ByTypeHandler(){

        }

        public ByTypeHandler(Value defaultValue) {
            this.defaultValue = defaultValue;
            hasDefaultValue = true;
        }

        public void Add(Type type, Value value) {
            list.Add(type, value);
        }

        public Value Get(Type type) {
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
