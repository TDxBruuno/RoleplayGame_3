namespace RoleplayGame
{
    public class Armor: Item, IDefenseItem
    {
        public int DefenseValue = 25;
        public Armor (string name): base (name)
        {

        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}