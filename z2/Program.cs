int Sum(int M, int N)
{
    if(M == N)
    {
        return M;
    }

    return N + Sum(M, N - 1);
}

Console.Write(Sum(1,15));
