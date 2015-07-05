﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder {
    public interface CardControl {
        void loadCard(Card newCard);
        void updateCard(Card card);
    }
}