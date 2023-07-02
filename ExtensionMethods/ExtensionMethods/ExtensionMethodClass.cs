

namespace ExtensionMethods;

public static class ExtensionMethodClass
{
    public static void SHOWarray(this int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n\n");
    }

    public static bool ValueToFind(this int[] arr, int value)
    {
        foreach (var item in arr)
        {
            if (item == value)
            {
                return true;
            }
        }
        return false;
    }

    public static int[] AddPositiveNumberToArr(this int[] arr, Predicate<int> predicate, int num)
    {
        int[] ints = new int[arr.Length + 1];
        if (predicate.Invoke(num) == false)
        {
            num *= -1;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            ints[i] = arr[i];
        }
        ints[ints.Length - 1] = num;
        arr = ints;
        return arr;       
    }

    public static int[] PlusAnotherArray(this int[] arr, int[] anotherArray)
    {
        Console.WriteLine($"\n Plus Another array");
        int[] newArray = new int[arr.Length + anotherArray.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            newArray[i] = arr[i];
        }
        for (int j = arr.Length, k = 0; j < newArray.Length; j++, k++)
        {
            newArray[j] = anotherArray[k];
        }
        arr = newArray;
        return arr;
    }

    public static bool ValuesssToFind(this int[] arr, params int[] valuesToFind)
    {
        int count = 0;
        for (int i = 0; i < valuesToFind.Length; i++)
        {
            for (int j = 0; j < arr.Length && i < valuesToFind.Length; j++)
            {
                if (valuesToFind[i] == arr[j])
                {
                    i++;
                    j = 0;
                    count++;
                }
            }
        }
        if (count == (valuesToFind.Length - 1))
            return true;
        else
            return false;

    }

    public static int[] SortArray(this int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                    swapped = true;
                }
            }

            n--;
        } while (swapped);

        return arr;
    }
}
