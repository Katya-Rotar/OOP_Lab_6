﻿using System.Text;

public class Person{
    private String name; private int age;
    public virtual string Name { // може бути перевизначений в похідних класах
        get { return name; }
        set
        {
            if (value.Length < 3) { 
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            name = value;
        }
    }
    public virtual int Age {
        get { return age; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }
    public Person(String name, int age){
        this.Name = name;
        this.Age = age;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(String.Format("Name {0}, Age: {1}", 
            this.Name,this.Age));
        return stringBuilder.ToString();
    }
}