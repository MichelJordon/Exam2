int n = Convert.ToInt32(System.Console.ReadLine());
var a = new int[n];
var used = new int[n];
int mn = 100000;
int mx = -100000;
for ( int i=0; i<n; i++ ){
    a[i] = Convert.ToInt32(System.Console.ReadLine());
    if ( mn > a[i] )
        mn = a[i];
    if ( mx < a[i] )
        mx = a[i];
}
bool locked = false;
for ( int i=0; i<n; i++ )
{
    if ( a[i] == mn ){
        locked = true;
    }
    if ( locked == true ){
        System.Console.Write($"{a[i]} ");
    }
    if ( a[i] == mx ){
        locked = false;
        return;
    }
    
}