using System;
using System.Collections.Generic;
using System.Linq;

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
        var collecionArticle = new List<Article>();
        int numberObject = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberObject; i++)
        {
            var inputLine = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var articleObject = new Article(inputLine[0], inputLine[1], inputLine[2]);
            collecionArticle.Add(articleObject);
        }
        string criterialSort = Console.ReadLine();
        switch (criterialSort)
        {
            case"title":
                collecionArticle=collecionArticle.OrderBy(x => x.Title).ToList();
                break;
            case "content":
                collecionArticle = collecionArticle.OrderBy(x => x.Content).ToList();
                break;
            case "author":
                collecionArticle = collecionArticle.OrderBy(x => x.Author).ToList();
                break;
        }
        foreach (var item in collecionArticle)
        {
            Console.WriteLine(item.ToString());
        }

    }
}

