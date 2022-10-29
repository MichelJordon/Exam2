public class Person{
    public List<string> fullname;
    public List<int> age;
    public Person()
    {
        fullname = new List<string>();
        aage = new List<int>();
    }
    public void GetFullName( string _fullname, int _age ){
        fullname.Add( _fullname );
        age.Add( _age );
    }
}