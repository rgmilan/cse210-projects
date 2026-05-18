using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Default Constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with 1 parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top
    public int GetTop()
    {
        return _top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns fraction as string
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Returns decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}