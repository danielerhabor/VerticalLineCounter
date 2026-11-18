public class LineCounterTests
{
    [Theory]
    [InlineData("single-thick-line.jpg", 1)]
    [InlineData("three-lines.jpg", 3)]
    [InlineData("full-black.jpg", 1)]
    [InlineData("seven-mixed-lines.jpg", 7)]
    [InlineData("all-white.jpg", 0)]
    [InlineData("single-thin-line.jpg", 1)]
    [InlineData("thin-white-gap.jpg", 2)]
    [InlineData("boundary-lines.jpg", 2)]
    [InlineData("five-even-lines.jpg", 5)]
    public void CountLines_RetunsExpected(string image, int expected)
    {
        var path = Path.Combine(AppContext.BaseDirectory, "Fixtures", "Generated", image);

        Assert.True(File.Exists(path), $"Image not found: {path}");
        Assert.Equal(expected, LineCounter.CountLines(path));
    }
}
