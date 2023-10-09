namespace RoleplayGame
{
    public class Sword: Item, IAttackItem
    {
        public int AttackValue = 20;
        public Sword (string name): base(name)
        {

        }
        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}