namespace ExtensionMethods;

internal class Program
{
    public static bool IsNumberPositive(int number)
    {
        return number > 0;
    }
    static void Main()
    {
        int[] array = { 43, 66, 5, 12, 90 };

        //SHow
        array.SHOWarray();
        //Sort(Direction direction = Direction.Descending) -> int[]
        array = array.SortArray();
        array.SHOWarray();

        //Find(int valueToFind) -> bool
        Console.WriteLine($"Has value? --> {array.ValueToFind(12)}");
        //Find(params int[] valuesToFind) -> bool
        Console.WriteLine($"Has value? --> {array.ValuesssToFind(12, 5, 90)}");
        //Plus(int[] anotherArr) -> int[]
        int[] anotherArray = { 90, 566, 399 };
        array = array.PlusAnotherArray(anotherArray);
        array.SHOWarray();
        //Get(Predicate<int> predicate) -> int[]
        Predicate<int> predicate = IsNumberPositive;
        array = array.AddPositiveNumberToArr(predicate, 67);
        array.SHOWarray();

    }
}