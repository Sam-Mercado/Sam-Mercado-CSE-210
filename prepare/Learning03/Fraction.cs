using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 0;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {

        return _top;

    }
    public int SetTop(int top)
    {
        _top = top;
        return _top;

    }
    public int GetBottom()
    {
        return _bottom;
    }
    public int SetBottom(int bottom)
    {
        _bottom = bottom;
        return _bottom;
    }

    public string GetFractionString()
    {
        //string myString = myInt.ToString();
        string topStr = _top.ToString();
        string bottomStr = _bottom.ToString();

        string fractionString = topStr + "/" + bottomStr;
        return fractionString;

    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;

    }
}