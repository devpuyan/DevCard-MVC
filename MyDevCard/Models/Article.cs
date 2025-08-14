namespace MyDevCard.Models;

public class Article
{
    public Article(long id, string name, string title, string des)
    {
        Id = id;
        Name = name;
        Title = title;
        Des = des;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Des { get; set; }
}