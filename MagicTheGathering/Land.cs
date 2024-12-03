using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    class Land
    {
        public enum ManaType { };

        private string naam;
        private ManaType manaType;

        public Land(string naam, ManaType type)
        {
            this.naam = naam;
            this.manaType = type;
        }
    }
}
