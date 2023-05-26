using System;

public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int Number){
        _top = Number;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionsString(){
        return _top.ToString() + "/" + _bottom.ToString();
    }
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}