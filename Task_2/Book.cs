using System.Text;

public class Book {
    private string title;
    public string Title
    {
        get { return this.title; } 
        set {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }
    private string author;
    public string Author
    {
        get
        {
            return this.author;
        }
        set
        {
            if(char.IsDigit(value.Split(' ')[1][0]))
            { //char.IsDigit(char) для перевірки першого символу другого імені автора після роздільника пробілу ' '. Якщо цей символ є цифрою, то генерується виняток з повідомленням "Author not valid!".
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }
    private decimal price;
    public virtual decimal Price {
        get
        {
            return this.price;
        }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }
    public Book(string author, string title, decimal price) {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }
    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
        .AppendLine($"Title: {this.Title}")
        .AppendLine($"Author: {this.Author}")
        .AppendLine($"Price: {this.Price:f2}");
        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}