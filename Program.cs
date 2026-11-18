
class Program
{
    static void Main(string[] args)
    {
        try
        {
             if (args.Length != 1)
        {
            Console.WriteLine("Usage: VerticalLineCounter <absolute-image-path>");
            return;
        }


        string filePath = args[0];

        if (!Path.IsPathFullyQualified(filePath))
        {
            Console.WriteLine("Error: Please provide an absolute image path.");
            return;
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: Image file does not exist.");
            return;
        }

        var count = LineCounter.CountLines(filePath);

        Console.WriteLine(count);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
       
    }
    
}

