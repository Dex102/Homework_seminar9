int Factorial(int N)
{
    if(N >= 1)
    {
        return N * (Factorial(N - 1));
    }

    return 1;
}

Console.Write(Factorial(4));