using System.ServiceModel;

namespace WCFCalculator
{
    // Define the service contract (interface)
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Subtract(double a, double b);

        [OperationContract]
        double Multiply(double a, double b);

        [OperationContract]
        string Divide(double a, double b);  // string to handle divide-by-zero message

        [OperationContract]
        double AreaOfCircle(double radius);

        [OperationContract]
        double AreaOfTriangle(double baseVal, double height);
    }
}
