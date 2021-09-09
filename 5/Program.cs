using System;
using System.IO;

class Program
{
    static void Main()
    {
        Employee.NexdId = 1000000;
        Console.WriteLine($"NextId = {Employee.NexdId}");

        Employee employee = new Employee("Inigo", "Montoya");
        Employee employee1 = new Employee("Inigo", "Montoya") { Title = "Computer Nerd", Salary = "Not enough" };
        Employee employee2;
        employee2 = new Employee();

        List<Employee> employees = new List<Employee>()
        {
            new Employee("Inigo", "Montoya"),
            new Employee("Kevin", "Bost")
        };

        // ERROR: The property or indexer 'Exployee.Id'
        // cannot be used in this context because the set
        // accessor is inaccessible
        employee1.Id = "490";

        employee2.SetName("Inigo", "Montoya");
        employee2.Save();

        // Modify employee2 after saving
        IncreaseSalary(employee2);

        // load employee1 from the saved version of employee2
        employee1 = DataStorage.Load("Inigo", "Montoya");

        Console.WriteLine($"{employee1.GetName()}: {employee1.Salary}");

        employee1.FirstName = "Inigo";
        employee1.LastName = "Montoya";
        employee1.Salary = "Too Little";
        Console.WriteLine(
            "{0} {1}: {2}",
            employee1.FirstName,
            employee1.LastName,
            employee1.Salary
        );

        employee1.Name = "Inigo Montoya";
        System.Console.WriteLine(employee1.Name);

        // Password is private, so it cannot be
        // accessed from outside the class
        // Console.WriteLine("Password = {0}", employee.Password);

        employee.SetName("Inigo", "Montoya");

        IncreaseSalary(employee1);

        Console.WriteLine($"{employee1.GetName()}: {employee1.Salary}");
    }

    static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "Enough to survive on";
    }
}
class Employee
{
    // public string FirstName;
    // public string LastName;
    public string Salary = "Not enough";

    private string Password;
    private bool IsAuthenticated;

    // private string FirstName;

    // public string GetFirstName()
    // {
    //     return FirstName;
    // }

    // public void SetFirstName(string newFirstName)
    // {
    //     if(newFirstName != null && newFirstName != "")
    //     {
    //         FirstName = newFirstName;
    //     }
    // }

    public Employee(string firstName, string lastName)
    {
        int id;
        FirstName = firstName;
        LastName = lastName;
        Initialize(id, firstName, lastName);
        Id = NextId++;
    }

    public static int NexdId = 42;

    public Employee(int id, string firstName, string lastName):this(firstName,lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Initialize(id, firstName, lastName);
    }

    public Employee(int id)
    {
        string firstName;
        string lastName;
        Id = id;

        Initialize(id, firstName, lastName);
    }
    public int Id { get; set; }


    public static int NextId
    {
        get
        {
            return _NextId;
        }
        private set
        {
            _NextId = value;
        }
    }
    public static int _NextId = 42;

    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            _FirstName = value;
        }
    }
    private string _FirstName;

    // private string LastName;

    // public string GetLastName()
    // {
    //     return LastName;
    // }

    // public void SetLastName(string newLastName)
    // {
    //     if(newLastName != null && newLastName != "")
    //     {
    //         LastName = newLastName;
    //     }
    // }

    public string LastName
    {
        get
        {
            return _LastName;
        }
        set
        {
            // _LastName = value;
            // Validate LastName assignment
            if (value == null)
            {
                // Report error
                // In C# 6.0 replace "value" with nameof(value)
                throw new ArgumentException("value");
            }
            else
            {
                // Remove any whitespace around
                // the new last name.
                value = value.Trim();
                if (value == "")
                {
                    // Report error
                    // In C# 6.0 replace "value" with nameof(value)
                    throw new ArgumentException("LastName cannot be black.", "value");
                }
                else
                    _LastName = value;
            }
        }
    }

    private string _LastName;

    public string Name
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
        set
        {
            // Split the assigned value into
            // first and last names.
            string[] names;
            names = value.Split(new char[] { ' ' });
            if (names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else 
            {
                // Throw an exception if the full
                // name was not assigned
                throw new System.ArgumentException($"Addigned value '{value}' is invalid", "value");
            }
        }
    }

    public string Title { get; set; }

    public Employee Manager { get; set; }

    public string Salary { get; set; } = "Not Enough";

    public bool Logon(string password)
    {
        if(Password==password)
        {
            IsAuthenticated = true;
        }
        return IsAuthenticated;
    }

    public bool GetIsAuthenticated()
    {
        return IsAuthenticated;
    }

    public string GetName()
    {
        return $"{Firstname} {LastName}";
    }

    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine($"Name changed to '{this.GetName}'");
    }

    public void Save()
    {
        DataStorage.Store(this);
    }

    // public void Initialize(string newFirstName, string newLastName)
    // {
    //     // Use property inside the Employee
    //     // class as well
    //     FirstName = newFirstName;
    //     LastName = newLastName;
    // }

    public void Initialize(int id)
    {
        // _Id = id.ToString();
        Id = id.ToString();

    }
    public void Initialize(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public string Id 
    {
        get
        {
            return _Id;
        }
        private set
        {
            _Id = value;
        }
    }

    private string _Id;
}

class DataStorage
{
    // Save an employee objext to a file
    // named with the Employee name.
    // Error handling not shown.
    public static void Store(Employee employee)
    {
        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Create will force
        // a new file to be created or override on
        // existing file.
        FileStream stream = new FileStream(
            employee.FirstName + employee.LastName + ".dat",
            FileMode.Create
        );

        // Create a StreamWriter object for writing text 
        // into the FileStream
        StreamWriter writer = new StreamWriter(stream);

        // Write all the data associated with the employee.
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);

        // Close the StreamWriter and its stream
        writer.Close();     // Automatically closes the stream
    }

    public static Employee Load(string firstName, string lastName)
    {
        Employee employee = new Employee();
        // Instantiate a FileStream using FirstNameLaseName.dat
        // for the filename. FileMode.Open will open
        // an existing file or wlse report an error.
        FileStream stream = new FileStream(firstName + lastName + ".dat", FileMode.Open);

        // Create a SteamReader for reading text from the file.
        StreamReader reader = new StreamReader(stream);

        // Read each line from the file and place it into
        // the associated property.
        employee.FirstName = reader.ReadLine();
        employee.LastName = reader.ReadLine();
        employee.Salary = reader.ReadLine();

        // Close the StreamReader and its stream.
        reader.Close();     // Automatically closes the stream
        return employee;
    }
}

    