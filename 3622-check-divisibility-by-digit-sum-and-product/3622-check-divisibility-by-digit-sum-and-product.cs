public class Solution
{
    public int Sum(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }

        return sum;
    }

    public int Prod(int n)
    {
        int prod = 1;

        while (n > 0)
        {
            prod = prod * (n % 10);
            n = n / 10;
        }

        return prod;
    }

    public bool CheckDivisibility(int n)
    {
        int sumOfDigit = Sum(n);
        int prodOfDigit = Prod(n);

         return n % (sumOfDigit + prodOfDigit) == 0;
    }
}