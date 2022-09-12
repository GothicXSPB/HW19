using Massive2;

public class Program
{
    public static void Main(string[] arg)
    {
        int[,] array = Math.Create();
        Math.Show(array);
        int min = Math.GetMin(array);
        Math.ShowConsole(min, "min");
        int[] indexMin = Math.GetMinIndex(array);
        Math.ShowConsole(indexMin, "IndexMin: ");
        int[] indexMax = Math.GetMaxIndex(array);
        Math.ShowConsole(indexMax, "IndexMax: ");
        int amount = Math.AmountMinElement(array);
        Math.ShowConsole(amount, "Number of maximum values: ");

    }
}