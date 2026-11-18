
using SkiaSharp;

public class LineCounter
{
    private const int BlackThreshold = 128;
    
    /// <summary>
    /// Counts continuous vertical black lines in a JPG image.
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns>The number of vertical black lines.</returns>
    public static int CountLines(string filePath)
    {
        using SKBitmap img = SKBitmap.Decode(filePath) ?? throw new InvalidDataException("Cannot decode the image.");

        // Every vertical line crosses the image's midpoint, so one row at that vertical offset is sufficient
        int midY = img.Height / 2;
        int width = img.Width;

        var numBlackLines = 0;
        var isPrevBlack = false;

        for (var x = 0; x < width; x++)
        {
            SKColor px = img.GetPixel(x, midY);
            var isBlack = px.Red < BlackThreshold && px.Green < BlackThreshold && px.Blue < BlackThreshold;
            if (isBlack)
            {
                isPrevBlack = true;
            }
            else if (!isBlack && isPrevBlack)
            {
                numBlackLines++;
                isPrevBlack = false;
            }
        }

        if (isPrevBlack)
        {
            numBlackLines++;
        }
        
        return numBlackLines;
    }
}