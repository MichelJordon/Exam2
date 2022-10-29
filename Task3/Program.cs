int n = Convert.ToInt32(System.Console.ReadLine());
int cnt = 1;
int forpow = 1;
for ( int i=1; i<n; i++ ){
    forpow += forpow;
    cnt += forpow;
}
System.Console.WriteLine(cnt);
