using Microsoft.AspNetCore.Mvc;
using MyDevCard.Models;

namespace MyDevCard.ViewComponents;

public class ProjectViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var projects = new List<Project>()
        {
            new Project(1, "senegal", "Senegal", "Maldiv is best country in Dream"),
            new Project(2, "senegal", "Senegal", "Maldiv is best country in Dream"),
            new Project(3, "senegal", "Senegal", "Maldiv is best country in Dream"),
            new Project(4, "senegal", "Senegal", "Maldiv is best country in Dream"),
            new Project(5, "senegal", "Senegal", "Maldiv is best country in Dream"),
            new Project(6, "senegal", "Senegal", "Maldiv is best country in Dream")

        };
        return View("_Projects", projects);

    }
}