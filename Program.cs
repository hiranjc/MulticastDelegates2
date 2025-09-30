using MulticastDelegates2.Services;

namespace MulticastDelegates2
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;
            op.Invoke(a, b);
        }
    }
}