public class Circle
{
    private double radius;
    private double pi = 3.14;
    public double GetArea( int num )
    {
        return num * num;
    }
    public double GetDiameter( int num )
    {
        return num * 2;
    }
    public double GetCircumference( int num )
    {
        return 2 * pi * num;
    }
    public double GetRadius( int num )
    {
        return num / 2;
    }

}