class Tire
{
    private double width;

    private double radius;

    private double aspectRatio;

    public Tire (double width, double radius, double aspectRatio)
    {
        this.width = width;
        this.radius = radius;
        this.aspectRatio = aspectRatio;

    }
    public void Display ()
    { 
        Console.WriteLine($"tire information : width : {width}, radius ; {radius}, aspaect ratio: {aspectRatio}" );
    }
}