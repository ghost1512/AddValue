class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        //add element
        Console.WriteLine("Add element: ");
        int newelement = Convert.ToInt32(Console.ReadLine());
        int[] newarray = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            newarray[i] = array[i];
        }
        newarray[n] = newelement;
        Console.Write("New Array: ");
        foreach (int element in newarray)
        {
            Console.Write(element);
        }
    }
}