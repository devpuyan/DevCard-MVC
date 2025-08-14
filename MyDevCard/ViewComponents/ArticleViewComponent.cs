using Microsoft.AspNetCore.Mvc;
using MyDevCard.Models;

namespace MyDevCard.ViewComponents;

public class ArticleViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var article = new List<Article>()
        {
            new Article(1, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(2, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(3, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(4, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(5, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(6, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(7, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(8, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            new Article(9, "bernard", "fwiewfejewfjn", "saldldskdask sadjjd as"),
            
            
        };
        return View("_article", article);
    }
}