namespace RoleplayGame
{
    public class Helmet: Item, IDefenseItem
    {
         public int DefenseValue = 18;
        public Helmet (string name): base (name)
        {

        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}