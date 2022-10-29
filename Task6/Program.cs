public class Calculator
{
    private long factorial;
    public Calculator()
    {
        factorial = 1;
    }
    public long Factorial( long n )
    {
        for ( int i=1; i<=n; i++ ){
            factorial *= i;
        }
        return factorial;
    }
    public double Multiple( double a, double b )
    {
        return a * b;
    }
    public double Division( int a, int b )
    {
        return (double) sum ;
    }
}