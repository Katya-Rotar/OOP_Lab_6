﻿public class MoodFactory{
    public Mood CreateMood(int points)
    {
        if (points < -5)
            return new Angry();
        else if (points >= -5 && points <= 0)
            return new Sad();
        else if (points >= 1 && points <= 15)
            return new Happy();
        else
            return new JavaScript();
    }
}