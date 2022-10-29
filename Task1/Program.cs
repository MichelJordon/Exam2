int n = Convert.ToInt32(System.Console.ReadLine());
var a = new int[n];
int cnt = 1;
for ( int i=0; i<n; i++ ){
    a[i] = Convert.ToInt32(System.Console.ReadLine());
    if ( i != 0 && a[i] != a[i-1] ){
        cnt ++;
    }
}
System.Console.WriteLine(cnt);