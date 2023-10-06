namespace RoleplayGame
{
    public class Staff: MagicalItem,IMagicalAttackItem, IMagicalDefenseItem
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