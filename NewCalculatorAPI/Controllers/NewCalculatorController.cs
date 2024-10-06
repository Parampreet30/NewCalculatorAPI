using Microsoft.AspNetCore.Mvc;

namespace NewCalculatorAPI.Inject;

public class NewCalculatorController : ControllerBase
{
    private readonly ICalculatorService<decimal> _calculator;

    public NewCalculatorController(ICalculatorService<decimal> calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("Add")]
    public decimal Add([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return _calculator.Add(left, right);
    }

     [HttpGet("Subtract")]
    public decimal Subtract([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return _calculator.Subtract(left, right);
    }

     [HttpGet("Multiply")]
    public decimal Multiply([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return _calculator.Multiply(left, right);
    }

     [HttpGet("Divide")]
    public decimal Divide([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return _calculator.Divide(left, right);
    }
}