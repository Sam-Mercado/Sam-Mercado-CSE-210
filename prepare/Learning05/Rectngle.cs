using System;

class Rectangle : Shape
{

    protected double _lenght;
    protected double _width;

    public double SetLenght(double lenght)
    {
        _lenght = lenght;
        return _lenght;
    }

    public double SetWidth(double width)
    {
        _width = width;
        return _width;
    }
    public override double GetArea()
    {
        //return base.GetArea();
        double area = _lenght * _width;
        return area;
    }
}