var person = new Person();
var list = new List<Person>();
int n = Convert.ToInt32(System.Console.ReadLine());
for ( int i=0; i<n; i++ ){
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Surname: ");
    string surname = Console.ReadLine();
    System.Console.Write("Age: ");
    int _age = Convert.ToInt32(Console.ReadLine());
    person.GetFullName( $"{name} {surname}", _age );
    list.Add(person); 
}
foreach (var item in list)
{
    int cnt = 0;
    foreach (var item1 in item.fullname)
    {
        System.Console.Write(item1);
        System.Console.WriteLine($"{item.age[cnt]}");
        cnt ++;
    }
    return;
}