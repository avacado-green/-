void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            PrintNumbers(M + 1, N);
        }
    }

    {
        int M = 2;  
        int N = 20; 

        PrintNumbers(M, N);
    }
