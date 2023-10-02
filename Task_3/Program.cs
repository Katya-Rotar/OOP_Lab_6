internal class Program
{
    private static void Main(string[] args)
    {
        string[] input_student = Console.ReadLine().Split(' ');
        string first_name_student = input_student[0];
        string last_name_student = input_student[1];
        string faculty_number = input_student[2];

        string[] input_worker = Console.ReadLine().Split(' ');
        string first_name_worker = input_worker[0];
        string last_name_worker = input_worker[1];
        decimal salary = int.Parse(input_worker[2]);
        decimal workin_hours = int.Parse(input_worker[3]);

        try
        {
            Student student = new Student(first_name_student, last_name_student, faculty_number);
            Console.WriteLine(student);
            Worker worker = new Worker(first_name_worker, last_name_worker, salary, workin_hours);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}