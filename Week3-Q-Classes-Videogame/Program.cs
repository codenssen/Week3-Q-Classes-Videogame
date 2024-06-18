namespace Week3_Q_Classes_Videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // itinialisation des personnages
            Character bob = new Character("Bob", 20, 10, 5);
            Character ana = new Character("Ana", 18, 12, 7);
            // On affiche chaque personnages
            bob.PrintCharacter();
            ana.PrintCharacter();

            // Boucle de combat, bob est attaqué par ana puis ana est attaqué par bob)
            while (bob.IsAlive() && ana.IsAlive())
            {
                bob.AttackedBy(ana);
                ana.AttackedBy(bob);
            }
            // Désigne le vainqueur
            if (bob.IsAlive())
            {
                Console.WriteLine("Bob a gagné !");
            } else
            {
                Console.WriteLine("Ana a gagné !");
            }
        }
    }
}
