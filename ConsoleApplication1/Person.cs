

using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age)
        : this(name, age, null)
    {
    }
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentNullException("Enter valid name.");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 && value > 100)
            {
                throw new ArgumentOutOfRangeException("Enter valid age, in the range [1 ... 100]");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (!value.Contains("@"))
            {
                throw new ArgumentNullException("Enter valid Email.");
            }
            this.email = value;
        }
    }

    public void PrintData()
    {
        Console.WriteLine("{0}, {1}, {2}",
            this.Name, this.Age, this.Email ?? "[No Email]");
    }
}