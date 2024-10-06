namespace NewCalculatorAPI.Inject;

public class CalculatorService : ICalculatorService<decimal>
{
    public decimal Add(decimal left, decimal right)
    {
        return left + right;
    }

    public decimal Divide(decimal left, decimal right)
    {
         return left / right;
    }

    public decimal Multiply(decimal left, decimal right)
    {
        return left * right;
    }

    public decimal Subtract(decimal left, decimal right)
    {
        return left - right;
    }
}
