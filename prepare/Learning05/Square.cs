using System;


class Square : Shape
{
    public double _side;

    public double SetSide(double num)
    {
        _side = num;
        return _side;
    }

    public override double GetArea()
    {
        //return base.GetArea();
        double area = Math.Pow(_side, 2); ;
        return area;
    }
}