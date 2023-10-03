public abstract class Mood{
    public abstract string MoodName { get; }
}
class Angry : Mood
{
    public override string MoodName => "Angry";
}
class Sad : Mood
{
    public override string MoodName => "Sad";
}
class Happy : Mood
{
    public override string MoodName => "Happy";
}
class JavaScript : Mood
{
    public override string MoodName => "JavaScript";
}
