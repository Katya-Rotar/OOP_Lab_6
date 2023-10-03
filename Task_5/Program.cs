internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int totalPoints = 0;
        FoodFactory foodFactory = new FoodFactory();
        MoodFactory moodFactory = new MoodFactory();
        for (int i = 0; i < input.Length; i++)
        {
            string inputFood = input[i];
            var food = foodFactory.CreateFood(inputFood);
            totalPoints += food.HappinessPoints;
        }
        Mood mood = moodFactory.CreateMood(totalPoints);
        Console.WriteLine(totalPoints + "\n" + mood);
    }
}