namespace CheesecakeCardBuilder.Builders {
    using System.Collections.Generic;

    public interface TypeLoader {
        void ApplyTags(List<string> tag);
    }
}
