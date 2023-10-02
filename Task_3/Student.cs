class Student : Human {
    private string faculty_number;
    public string Faculty_number {
        get { return this.faculty_number; }
        set
        {
            if (value.Length >= 5 && value.Length <= 10)
            {
                this.faculty_number = value;
            }
            else {
                throw new ArgumentException("Invalid faculty number!");
            }
        }
    }

    public Student(string first_name, string last_name, string faculty_number) : base(first_name, last_name)
    {
        this.Faculty_number = faculty_number;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nFaculty number: {faculty_number}";
    }
}
