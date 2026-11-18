using SkiaSharp;

namespace VerticalLineCounter;

class Program
{
    static void Main(string[] args)
    {
        // var file = "/Users/derhabor/Documents/Unassigned/programming/VerticalLineCounter/img_1.jpg";
        // var file = "/Users/derhabor/Documents/Unassigned/programming/VerticalLineCounter/img_2.jpg";
        // var file = "/Users/derhabor/Documents/Unassigned/programming/VerticalLineCounter/img_3.jpg";
        var file = "/Users/derhabor/Documents/Unassigned/programming/VerticalLineCounter/img_4.jpg";

        if (!Path.IsPathFullyQualified(file))
        {
            Console.WriteLine("Path is not fully qualified");
        }

        using SKBitmap img = SKBitmap.Decode(file);

        int midY = img.Height / 2;
        int width = img.Width;

        byte threshold = 128;

        var numBlackLines = 0;

        var isPrevBlack = false;

        for (var x = 0; x < width; x++)
        {
            SKColor px = img.GetPixel(x, midY);
            // starting line
            var isBlack = px.Red < threshold &&
                          px.Green < threshold &&
                          px.Blue < threshold;
            if (isBlack)
            {
                isPrevBlack = true;
            }
            else if (!isBlack && isPrevBlack)
            {
                numBlackLines++; // seen a white after a black finishing line
                isPrevBlack = false;
            }
        }

        if (isPrevBlack)
        {
            numBlackLines++; // assuming black line spans to the end of the width
        }

        Console.WriteLine("Hello world!");
        Console.WriteLine($"Number of lines: {numBlackLines}");
    }
    
}

