using Microsoft.AspNetCore.Mvc;
using WebShopBrodova.Data;
using WebShopBrodova.Models;

namespace WebShopBrodova.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;
    public CategoryController(ApplicationDbContext context)
    {
         _context = context;
    }
    public IActionResult Index()
    {
        List<TypeBoat> types =_context.TypesOfBoats.ToList();
        return View(types);
    }
}
