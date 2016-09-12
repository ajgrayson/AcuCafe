namespace AcuCafe.Contracts
{
    public interface IDrinkFactory
    {
        Drink Create(string type);
    }
}
