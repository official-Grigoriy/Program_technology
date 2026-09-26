namespace pract1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создан объект класса person с именем Adolf
            //и вызываем конструктор по умолчанию
            //Person Adolf = new Person();
            Person Adolf = new Person("Adolf", "schwarc", new DateOnly(1934,7,23));

            Person _default = new Person();

            // _default.Birthday = new DateOnly(01, 01, 01);
            Console.WriteLine(_default.GetData());
            Console.WriteLine(Adolf.Fullname+" "+Adolf.Birthday);

            bool flag = Adolf.ChangeFirstname("Ghans");
            if (flag) Console.WriteLine(Adolf.GetData());
            else Console.WriteLine("не удалось вывести");

            flag = Adolf.ChangeBirthday(new DateOnly(2014, 12, 05));
            if (flag) Console.WriteLine(Adolf.GetData());
            else Console.WriteLine("не удалось вывести");
            
            if (Adolf.IsAdult)
                Console.WriteLine(">18");
            else Console.WriteLine("<18");
        }
    }

}
