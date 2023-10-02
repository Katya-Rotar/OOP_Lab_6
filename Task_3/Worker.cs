class Worker : Human{
    private decimal salary;
    public decimal Salary {
        get { return salary; }
        set
        {
            if (value > 10)
            {
                this.salary = value;
            }
            else {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
        }
    }
    private decimal workin_hours;
    public decimal Workin_hours {
        get { return workin_hours; }
        set {
            if (value >= 1 && value <= 12)
            {
                this.workin_hours = value;
            }
            else {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
        }
    }

    public Worker(string first_name, string last_name, decimal salary, decimal workin_hours) : base(first_name, last_name)
    {
        this.Salary = salary;
        this.Workin_hours = workin_hours;
    }
    public static decimal Salary_per_hour(decimal salary, decimal workin_hours) {
        return (salary / (workin_hours * 5));
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nWeek Salary: {salary}\nHours per day: {workin_hours}\nSalary per hour: {Salary_per_hour(salary, workin_hours)}";
    }
}
