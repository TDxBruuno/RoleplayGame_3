namespace RoleplayGame
{
    public class Staff: IMagicalItem,IMagicalAttackItem, IMagicalDefenseItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}