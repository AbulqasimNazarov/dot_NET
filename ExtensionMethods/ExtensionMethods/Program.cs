namespace ExtensionMethods;

internal class Program
{
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
    }
}