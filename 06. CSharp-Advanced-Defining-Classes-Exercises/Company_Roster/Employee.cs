class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string inputName, double inputSalary, string inputPosition, string inputDepartment,  int inputAge)
    : this(inputName, inputSalary, inputPosition, inputDepartment)
    {
        this.MyAge = inputAge;
        this.email = "n/a";
    }

    public Employee(string inputName, double inputSalary, string inputPosition, string inputDepartment, string inputEmail)
    : this(inputName, inputSalary, inputPosition, inputDepartment)
    {
        this.MyEmail = inputEmail;
        this.age = -1;
    }

    public Employee(string inputName, double inputSalary, string inputPosition, string inputDepartment, string inputEmail,int inputAge)
        :this(inputName,  inputSalary,  inputPosition,  inputDepartment)
    {
        this.MyEmail = inputEmail;
        this.MyAge = inputAge;
    }

    public Employee(string inputName, double inputSalary, string inputPosition, string inputDepartment)
    {
        this.MyName = inputName;
        this.MySalary = inputSalary;
        this.MyPosition = inputPosition;
        this.MyDepartment = inputDepartment;
        this.email = "n/a";
        this.age = -1;

    }

    public Employee()
    {

    }

    public int MyAge
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string MyEmail
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public string MyDepartment
    {
        get { return this.department; }
        set { this.department = value; }
    }

    public string MyPosition
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public double MySalary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public string MyName
    {
        get { return this.name; }
        set { this.name = value; }
    }

}

