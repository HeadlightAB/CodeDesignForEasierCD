namespace Business
{
    public interface IBetterManager
    {
        void In(uint quantity);
        void Out(uint quantity);
        int GetBalance();
    }
}