public class Human{
    private string first_name;
    public string First_name {
        get { return this.first_name; }
        set {
            char capital_letter = value[0];
            if (char.IsUpper(capital_letter))
            {
                this.first_name = value;
            }
            else {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length > 3)
            {
                this.first_name = value;
            }
            else {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
        }
    }
    private string last_name;
    public string Last_name
    {
        get { return this.last_name; }
        set
        {
            char capital_letter = value[0];
            if (char.IsUpper(capital_letter))
            {
                if (value.Length > 2)
                {
                    this.last_name = value;
                }
                else
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName ");
                }
            }
            else
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
        }
    }
    public Human(string first_name, string last_name) {
        this.First_name = first_name;
        this.Last_name = last_name;
    }
    public override string ToString()
    {
        return $"\nFirst Name: {first_name} \nLast Name: {last_name}";
    }
}
