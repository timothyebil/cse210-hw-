using System;

public class Fraction
{
    // Private attributes (Encapsulation)
    private int _numerator;
    private int _denominator;

    // 1. Constructor: No parameters (initializes to 1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // 2. Constructor: One parameter (top) (initializes to top/1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // 3. Constructor: Two parameters (top and bottom)
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to return fraction string "top/bottom"
    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    // Method to return decimal value
    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}
