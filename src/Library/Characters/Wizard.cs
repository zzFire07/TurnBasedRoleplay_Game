namespace RoleplayGame
{
    public class Wizard : MagicCharacter, IHeroes
    {

        public Wizard(string name) : base(name)
        {
            Staff staff = new Staff();
            SpellsBook spellsBook = new SpellsBook();
            
            this.EquipItem(staff);
            this.EquipItem(spellsBook);
        }
    }
}