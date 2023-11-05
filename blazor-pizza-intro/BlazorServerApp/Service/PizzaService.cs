namespace BlazingPizza.Data;

public interface IPizzaService{
    Task<Pizza[]> GetPizzasAsync();
}

public class PizzaService : IPizzaService
{
    public PizzaService()
    {
    }

    public Task<Pizza[]> GetPizzasAsync()
    {
    // Call your data access technology here
       throw new NotImplementedException();
    }
}