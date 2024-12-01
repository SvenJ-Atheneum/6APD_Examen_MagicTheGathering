namespace MagicTheGathering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maak 3 Creatures aan, bewaar ze in een Array.
            Creature[] creatures = new Creature[3];



            //Maak Land-kaarten aan zoals ingegeven door de gebruiker. Bewaar de Land-kaarten in een Array.
            Land[] landen = new Land[1]; //LET OP: juiste lengte gebruiken!



            //Toon de 3 Creatures en laat de gebruiker er ééntje kiezen.




            //Controleer of het gekozen Creature kan opgeroepen worden met de aangemaakte Land-kaarten.
            Creature.canCast(landen, creatures[0]);
        }
    }
}
