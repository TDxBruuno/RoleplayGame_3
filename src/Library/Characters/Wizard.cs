using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : Character
    {
        private List<MagicalItem> magicalItems = new List<MagicalItem>();

        public Wizard(string name) : base(name)
        {
            AddItem(new Staff());
        }

        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in magicalItems)
                {
                    if (item is AttackItem attackItem)
                    {
                        value += attackItem.AttackValue;
                    }
                }
                foreach (MagicalItem item in magicalItems)
                {
                    if (item is IMagicalAttackItem magicalAttackItem)
                    {
                        value += magicalAttackItem.AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Item item in magicalItems)
                {
                    if (item is DefenseItem defenseItem)
                    {
                        value += defenseItem.DefenseValue;
                    }
                }
                foreach (MagicalItem item in magicalItems)
                {
                    if (item is IMagicalDefenseItem magicalDefenseItem)
                    {
                        value += magicalDefenseItem.DefenseValue;
                    }
                }
                return value;
            }
        }

        public void AddItem(MagicalItem item)
        {
            magicalItems.Add(item);
        }

        public void RemoveItem(MagicalItem item)
        {
            magicalItems.Remove(item);
        }
    }
}
    /* public class Wizard: IMagicCharacter
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
        {
            this.Name = name;
            
            this.AddItem(new Staff());
        }

        public string Name { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

    } */
