using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicCharacter
    {
        private List<MagicalItem> magicalItems = new List<MagicalItem>();
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
    
    /*
    public interface IMagicCharacter: ICharacter
    {
        void AddItem(IMagicalItem item);

        void RemoveItem(IMagicalItem item);
    }
    */

