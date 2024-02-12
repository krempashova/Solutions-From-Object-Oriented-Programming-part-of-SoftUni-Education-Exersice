﻿
namespace Shapes 
{ 

    public class Rectangle : Shape
   {
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public double Height { get;private set; }
    public double  Width { get;  private set; }

    public override double CalculateArea()
    => Height * Width;

    public override double CalculatePerimeter()
   => 2 * Height + 2 * Width;

    public override string Draw()
    {
        return base.Draw();
    }
}
}
