using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit
            //Manat manat = new Manat(200);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region TypeList
            //StringList stringList = new StringList();
            //stringList.Add("Seid");
            //stringList.Add("Emil");
            //stringList.GetAll();

            //IntList list = new IntList();
            //list.Add(34);
            //list.Add(65);
            //list.GetAll();
            //Booklist booklist = new Booklist();

            //Book book1 = new Book
            //{
            //    Author = "Dale Carnegie",
            //    Name = "Dostlari Nece Qazanmali"

            //};
            //Book book2 = new Book()
            //{
            //    Author = "Mehemmed Fuzuli",
            //    Name = "Leyli ve Mecnun"

            //};
            //Book book3 = new Book()
            //{
            //    Author = "Nizami",
            //    Name = "Xosrov ve Sirin"
            //};



            //booklist.Add(book1);
            //booklist.Add(book2);
            //booklist.Add(book3);
            //booklist.GetAll();

            #endregion

            #region Generic
            //DataList<string> stringlist = new DataList<string>();
            //stringlist.Add("emil");
            //stringlist.Add("Seid");
            //stringlist.Add("Eli");
            //stringlist.GetAll();

            //DataList<int> intlist = new DataList<int>();
            //intlist.Add(33);
            //intlist.Add(22);
            //intlist.Add(11);

            //intlist.GetAll();
            #endregion

            #region Generik spesifik
            //Employee<string> employee1 = new Employee<string>();
            //Employee<int> employee2 = new Employee<int>();
            //Employee<Person> employee3 = new Employee<Person>();
            //Employee<Test> employee4 = new Employee<Test>();

            //Employee<Test, ITest> employee5 = new Employee<Test, ITest>();
            #endregion

            #region Operator Overloading
            //Employee employee = new Employee(33,"Eli");
            //Student student = new Student(23,"Seid");

            //Console.WriteLine(employee > student);
            #endregion

        }
    }
    #region Operator Overloading
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Student(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Employee(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public static bool operator >(Employee employee, Student student)
    //    {
    //        return employee.Age > student.Age;
    //    }
    //    public static bool operator <(Employee employee, Student student)
    //    {
    //        return employee.Age < student.Age;
    //    }
    //}
    #endregion

    #region Generic spesifik
    //public class Employee<T, U> where T : class
    //                           where T : new()
    //                           where T : Common
    //                           where T : U
    //{

    //}
    //public abstract class Common
    //{

    //}
    //public class Person : Common
    //{

    //    public string Name { get; set; }
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //}
    //public class Test : ITest
    //{

    //}
    //public interface ITest
    //{

    //}
    #endregion


    #region Generic
    //public class DataList<T>
    //{
    //    private T[] arr;
    //    public DataList()
    //    {
    //        arr = new T[0];
    //    }

    //    public void Add(T data)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = data;

    //    }
    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }


    //}
    #endregion


    #region Typelist
    //public class StringList
    //{
    //    private string[] arr;
    //    public StringList()
    //    {
    //        arr = new string[0];
    //    }

    //    public void Add(string str)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = str;

    //    }
    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    //public class IntList
    //{
    //    private int[] arr;
    //    public IntList()
    //    {
    //        arr = new int[0];
    //    }

    //    public void Add(int num)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = num;

    //    }
    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    //public class Booklist
    //{
    //    private Book[] arr;
    //    public Booklist()
    //    {
    //        arr = new Book[0];
    //    }

    //    public void Add(Book book)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = book;

    //    }
    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item.Author + " - " + item.Name);
    //        }
    //    }

    //    public class Book
    //    {
    //        public string Author { get; set; }
    //        public string Name { get; set; }
    //    }
    //}
    #endregion


    #region implicit
    //public class Dollar
    //{
    //    public double Usd { get; set; }

    //    public Dollar(double usd)
    //    {
    //        Usd = usd;
    //    }
    //}

    //public class Manat
    //{
    //    public double Azn { get; set; }

    //    public Manat(double azn)
    //    {
    //        Azn = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.Azn / 1.7);
    //    }
    //}
    #endregion



}