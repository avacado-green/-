void PrintReverse(int[] arr, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(arr[index]);
        PrintReverse(arr, index - 1);
    }

    {
        int[] arr = new int[] {5, 4, 3, 2, 1, -1, -2, -3, -4, -5};
        PrintReverse(arr, arr.Length - 1);
    }