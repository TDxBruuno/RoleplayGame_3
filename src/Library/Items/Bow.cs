namespace RoleplayGame
{
    public class Bow: Item, IAttackItem
    {
        public int AttackValue = 15;
        public Bow (string name): base(name)
        {

        }
        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}