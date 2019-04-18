using System;

class Article
{
    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public void EditTitle(string newTitle)
    {
        this.Title = newTitle;
    }
    public void ChangeAuthor(string newAuthor)
    {
        this.Author = newAuthor;
    }
    public void EditContent(string newContent)
    {
        this.Content = newContent;
    }
    public override string ToString()
    {
        return $"{this.Title} - {this.Content}: {this.Author}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        //"{title}, {content}, {author}"
        var inputLine = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        var articleObject = new Article(inputLine[0], inputLine[1], inputLine[2]);
        int numberCorrection = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberCorrection; i++)
        {
            var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
            switch (command[0])
            {
                case "Edit":
                    articleObject.EditContent(command[1]);
                    break;
                case "ChangeAuthor":
                    articleObject.ChangeAuthor(command[1]);
                    break;
                case "Rename":
                    articleObject.EditTitle(command[1]);
                    break;
            }
        }
        Console.WriteLine(articleObject.ToString());
    }
}

