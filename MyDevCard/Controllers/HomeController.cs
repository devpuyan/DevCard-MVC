using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyDevCard.Models;

namespace MyDevCard.Controllers;

public class HomeController : Controller
{

    public readonly List<Service> _Services = new List<Service>()
    {
        new Service(1, "ali"),
        new Service(2, "ali"),
        new Service(3, "ali"),
        new Service(4, "ali"),
        new Service(5, "ali"),
        new Service(6, "ali"),

    };
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        var contact = new Contact()
        {
            Services = new SelectList(_Services, "Id", "Name")
        };
        return View(contact);
    }

    [HttpPost]
    public IActionResult Contact(Contact form)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Error = "اطلاعات وارد شده صحیح نیست دوباره تلاش کنید";
            return View(form);
        }
        else
        {
            ViewBag.Success = "پیغام شما ارسال شد با تشکر";
            return View();
        }
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}