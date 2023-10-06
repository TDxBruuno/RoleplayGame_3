using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicCharacter
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        public void AddItem(IMagicalItem item)
        {
            magicalItems.Add(item);
        }
        public void RemoveItem(IMagicalItem item)
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

