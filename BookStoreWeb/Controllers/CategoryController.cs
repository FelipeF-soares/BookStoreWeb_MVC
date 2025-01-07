using BookStoreWeb.Data;
using BookStoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext context;

    public CategoryController(ApplicationDbContext context)
    {
        this.context = context;
    }
    public IActionResult Index()
    {
       var listCategory = context.Categories.ToList();
        return View(listCategory);
    }
}
