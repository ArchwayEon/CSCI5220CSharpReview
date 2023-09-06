namespace CSCI5220CSharpReview;

internal class Rectangle : IAreaReporter
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }
}
