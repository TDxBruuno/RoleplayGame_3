namespace RoleplayGame
{
    public class Shield: Item, IDefenseItem
    {
        public int DefenseValue = 14;
        public Shield (string name): base (name)
        {

        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}