using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Character
    {
        public int health =  100;
        public List<IItem> items = new List<IItem>();
        public Character(string name)
        {
            Name = name;
        }
        public string Name{get; set;}
        public abstract int AttackValue{get;}
        public abstract int DefenseValue{get;}
        public int Health
        {
            get => health;
            private set => health = value < 0 ? 0 : value;
        }
        public void ReceiveAttack(int power)
        {
            if (DefenseValue < power)
            {
                Health -= power - DefenseValue;
            }
        }

        public void Cure()
        {
            Health = 100;
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }


        /*
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        void Cure();

        void ReceiveAttack(int power);
        */
    }
}