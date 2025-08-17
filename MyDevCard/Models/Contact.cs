using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyDevCard.Models;

public class Contact
{
    // public Contact(string name, string email, string message, string service)
    // {
    //     Name = name;
    //     Email = email;
    //     Message = message;
    //     Service = service;
    // }

    [Required(ErrorMessage = "مقدار این فیلد اجباری است")]
    [MaxLength(10, ErrorMessage = "تعداد کاراکتر باید از ۱۰ کوچکتر باشد")]
    [MinLength(3, ErrorMessage = "تعداد کاراکتر باید از ۳ بزرگتر باشد")]
    public string Name { get; set; }
    [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
    [Required(ErrorMessage = "مقدار این فیلد اجباری است")]
    public string Email { get; set; }
    public string Message { get; set; }
    public string Service { get; set; }
    public SelectList Services { get; set; }
}