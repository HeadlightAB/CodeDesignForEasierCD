using System;

namespace Business
{
    public class BetterManager : IBetterManager
    {
        public int GetBalance() => Balance.Value;
        
        public void In(uint quantity)
        {
            if (quantity + Balance.Value > 1000)
            {
                throw new NotSupportedException("Not enough space");
            }

            Balance.Value += (int)quantity;
        }

        public void Out(uint quantity)
        {
            if (quantity > Balance.Value)
            {
                throw new NotSupportedException("Not enough in stock");
            }

            Balance.Value -= (int) quantity;
        }
    }
}