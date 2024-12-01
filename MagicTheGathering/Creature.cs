using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    class Creature
    {
        //velden
        private string creatureName;
        private Land.ManaType manaType;
        private int amountColoredTypeNeeded;
        private int amountUnColoredTypeNeeded;
        private string specialAbilities;
        private string flavourText;
        private int attack;
        private int defense;
        //Constructor
        public Creature(string creatureName, Land.ManaType manaType, int amountColoredTypeNeeded, int amountUncoloredTypeNeeded, string specialAbilities, string flavourText, int attack, int defense)
        {
            this.creatureName = creatureName;
            this.manaType = manaType;
            this.amountColoredTypeNeeded = amountColoredTypeNeeded;
            this.amountUnColoredTypeNeeded = amountUncoloredTypeNeeded;
            this.specialAbilities = specialAbilities;
            this.flavourText = flavourText;
            this.attack = attack;
            this.defense = defense;
        }

        public static bool canCast(Land[] landen, Creature creature)
        {
            return false;
        }

    }

    
}
