class Methods
{
    // Method with no return
    void PrintSum(int digit1, int digit2)
    {
        Console.WriteLine($"Sum is {digit1 + digit2}");
    }

    // Method with return type
    int CountSum(int digit1, int digit2)
    {
        return digit1 + digit2;
    }

    // Method overloading - same method names different parameters

    int Sum(int digit1, int digit2)
    {
        return digit1 + digit2;
    }

    int Sum(int digit1, int digit2, int digit3)
    {
        return digit1 + digit2 + digit3;
    }
}
