using System;
using System.Globalization;

class Circle : Shape
{

    protected double _radius;

    public double SetRadius(double num)
    {
        _radius = num;
        return _radius;
    }

    public override double GetArea()
    {
        //return base.GetArea();
        double area = Math.Round(3.14159265359, 2) * Math.Pow(_radius, 2);
        return area;
    }



}