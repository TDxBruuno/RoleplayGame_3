using System.Collections.Generic;
namespace RoleplayGame
{

    public class Dwarf : Character
    {
        public Dwarf(string name) : base(name)
        {
            AddItem(new Axe());
            AddItem(new Helmet());
        }

        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in items)
                {
                    if (item is AttackItem attackItem)
                    {
                        value += attackItem.AttackValue;
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
                foreach (Item item in items)
                {
                    if (item is DefenseItem defenseItem)
                    {
                        value += defenseItem.DefenseValue;
                    }
                }
                return value;
            }
        }
    }   

}
    /* public class Dwarf: ICharacter
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Dwarf(string name)
        {
            this.Name = name;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
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
    } */
