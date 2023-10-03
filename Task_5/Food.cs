public abstract class Food {
    public abstract int HappinessPoints { get; }
}
public class Cram : Food
{
    public override int HappinessPoints => 2;
}
public class Lembas : Food
{
    public override int HappinessPoints => 3;
}
public class Apple : Food {
    public override int HappinessPoints => 1;
}
public class Melon : Food
{
    public override int HappinessPoints => 1;
}
public class HoneyCake : Food
{
    public override int HappinessPoints => 5;
}
public class Mushrooms : Food
{
    public override int HappinessPoints => -10;
}
public class OtherFood: Food
{
    public override int HappinessPoints => -1;
}