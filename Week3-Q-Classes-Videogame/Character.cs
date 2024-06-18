
namespace Week3_Q_Classes_Videogame
{
    public class Character
    {
        // Propriétés
        private string _name;
        private int _lifepoint;
        private int _strength;
        private int _defense;


        public Character(string name, int lifepoint, int strength, int defense)
        {
            _name = name;
            _lifepoint = lifepoint;
            _strength = strength;
            _defense = defense;
        }

        public bool IsAlive()
        {
            return (_lifepoint <= 0 ? false : true);
        }
        public int GetStrength()
        {
            return _strength;
        }
        public string GetName()
        {
            return _name;
        }
        public void AttackedBy(Character character)
        {
            Console.WriteLine($"{_name} est attaqué par {character.GetName()}");
            _lifepoint = _lifepoint - (character.GetStrength() - _defense);
        }
        public void PrintCharacter()
        {
            Console.WriteLine($"Nom du personnage : {_name}");
            Console.WriteLine($"Point de vie : {_lifepoint}");
            Console.WriteLine($"Force : {_strength}");
            Console.WriteLine($"Défense : {_defense}");
            Console.WriteLine("");
        }

    }

}
