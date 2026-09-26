namespace pract1;

internal class Person
{
    // данные
    // 1. поля класса (почти всегда private)

    private string _firstname;
    private string _lastname;
    //private DateOnly birthday;

    //public DateOnly Birthday 
    //{
    //    get { return birthday; }

    //   private set { birthday = value; }
    
    //}

    // 2. свойства (часто public)
    //2.1 автоматические свойства
    public DateOnly Birthday { get; private set;}

    //2.2 не автоматисекие
    public string Fullname
    { 
        get
        {
            return _firstname + " " + _lastname;
        }
    }

    //Свойства
    //Есть ли 18 лет?
    public bool IsAdult
    {
        get
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            return today.AddYears(-18) > Birthday;
        }
    }
 

    //конструкторы - специальные методы для создания объектов
    // 1. конструктор с параметрами
    public Person(string firstname, string lastname, DateOnly birthday)
    {
        _firstname = firstname;
        _lastname = lastname;
        Birthday = birthday;
    }
    //2. конструктор по умолчанию
    public Person()
    {
        _firstname = "none";
        _lastname = "none";
        Birthday = new DateOnly(1405, 04, 23);
    }

    //методы
    //для смены имени
    public bool ChangeFirstname(string newFirstname)
    {
        if (string.IsNullOrWhiteSpace(newFirstname))
            return false;
        _firstname = newFirstname;
        return true;
    }

    //для изменения фамилии
    public bool ChangeLastname(string newLastname)
    {
        if (string.IsNullOrWhiteSpace(newLastname))
            return false;
        _lastname = newLastname;
        return true;
    }

    //для изменения даты рождения
    public bool ChangeBirthday(DateOnly newBirthday)
    {
        if (newBirthday > DateOnly.FromDateTime(DateTime.Now) ||
            newBirthday < DateOnly.FromDateTime(DateTime.Now).AddYears(-120))
            return false;
        Birthday = newBirthday;
        return true;
    }

    //для вывода ввсех данных
    public string GetData()
    {
        //string Data = _lastname + " " + _firstname + " " + Birthday.ToString();
        return Fullname +  " " + Birthday;
    }
}
