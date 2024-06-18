
namespace Week3_Q_Classes_Videogame
{
    public class Character
    {
        // Propriétés
        private string _name;
        private int _healthpoint;
        private int _strength;
        private int _defense;


        public Character(string name, int healthpoint, int strength, int defense)
        {
            _name = name;
            _healthpoint = healthpoint;
            _strength = strength;
            _defense = defense;
        }

        public bool IsAlive()
        {
            return (_healthpoint <= 0 ? false : true);
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
            _healthpoint = _healthpoint - (character.GetStrength() - _defense);
        }
        public void PrintCharacter()
        {
            Console.WriteLine($"Nom du personnage : {_name}");
            Console.WriteLine($"Point de vie : {_healthpoint}");
            Console.WriteLine($"Force : {_strength}");
            Console.WriteLine($"Défense : {_defense}");
            Console.WriteLine("");
        }

    }

}
