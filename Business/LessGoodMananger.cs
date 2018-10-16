using System;

namespace Business
{
    public class LessGoodMananger : ILessGoodMananger
    {
        public int GetBalance() => Balance.Value;

        public void InOut(int quantity)
        {
            if (quantity < 0)
            {
                if (Balance.Value + quantity < 0)
                {
                    throw new NotSupportedException("Not enough in stock");
                }
            }

            Balance.Value += quantity;
        }
    }
}