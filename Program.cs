Person[] arr = new Person[3];
for (int i = 0; i <= 2; i++)
{
    Console.WriteLine("Введите адресс");
    string a = Console.ReadLine();
    Console.WriteLine("Введите факультет");
    string b = Console.ReadLine();
    arr[i] = new Person(a, b);
    Console.WriteLine("Введите ФИО");
    arr[i].fio = Console.ReadLine();
    Console.WriteLine("Введите год поступления");
    arr[i].Date = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите телефон");
    arr[i].Tel = Console.ReadLine();
    Console.WriteLine("Введите курс");
    arr[i].Kurs = Convert.ToInt32(Console.ReadLine());
}
one(arr);
two(arr);
three(arr);

void one(Person[] a)
{
    Console.WriteLine("Список студентов");
    foreach (Person i in a)
    {
        Console.WriteLine(i.fio);
    }
}
void two(Person[] a)
{
    Console.WriteLine("Введите факультет");
    string d = Console.ReadLine();
    foreach (Person i in a)
    {
        if (i.Fac == d)
        {
            Console.WriteLine(i.fio);
        }
    }
}
void three(Person[] a)
{
    Console.WriteLine("Введите минимальный год");
    int f = Convert.ToInt32(Console.ReadLine());
    foreach (Person i in a)
    {
        if (i.Date > f)
        {
            Console.WriteLine(i.fio);
        }
    }
}
class Person
{
    string FIO { get; set; }
    int date { get; set; }
    string adress { get; }
    string tel { get; set; }
    int kurs { get; set; }
    string fac { get; }
    public Person(string adress, string fac)
    {
        this.adress = adress;
        this.fac = fac;
    }
    public string fio
    {
        get
        {
            return this.FIO;
        }
        set
        {
            this.FIO = value;
        }
    }
    public int Date
    {
        get
        {
            return this.date;
        }
        set
        {
            this.date = value;
        }
    }
    public string Adress
    {
        get
        {
            return this.adress;
        }
    }
    public string Tel
    {
        get
        {
            return this.tel;
        }
        set
        {
            this.tel = value;
        }
    }
    public int Kurs
    {
        get
        {
            return this.kurs;
        }
        set
        {
            this.kurs = value;
        }
    }
    public string Fac
    {
        get
        {
            return this.fac;
        }
    }
}