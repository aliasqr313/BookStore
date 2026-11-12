using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

public class Book
{
    public int Id { get; set; }

    [Required(ErrorMessage = "عنوان را وارد کنید")]
    public string Title { get; set; } = "";

    [Required(ErrorMessage = "نام نویسنده را وارد کنید")]
    public string Author { get; set; } = "";

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? ImageFileName { get; set; }
}