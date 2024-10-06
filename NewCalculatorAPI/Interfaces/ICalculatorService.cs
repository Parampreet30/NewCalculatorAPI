namespace NewCalculatorAPI.Inject;

public interface ICalculatorService<T> {
T Add(T left,T right);

T Subtract(T left,T right);

T Multiply(T left,T right);

T Divide(T left,T right);


}