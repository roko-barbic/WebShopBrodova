using Microsoft.AspNetCore.Mvc;
using WebShopBrodova.DataAccess.Data;
using WebShopBrodova.DataAccess.Repository;
using WebShopBrodova.DataAccess.Repository.IRepository;
using WebShopBrodova.Models.Models;

namespace WebShopBrodova.Controllers;

public class CategoryController : Controller
{
    //private readonly ApplicationDbContext _context;
    private readonly IUnitOfWork _unitOfWork;

    public CategoryController(IUnitOfWork unitOfWork)
    {
         _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        List<TypeBoat> typesOfBoats = _unitOfWork.TypeOfBoat.GetAll().ToList();
        return View(typesOfBoats);
    }

    public IActionResult Create()
    {
        return View();
    }
    
    public IActionResult Create(TypeBoat typeBoat)
    {
        List<TypeBoat> typeBoatList = _unitOfWork.TypeOfBoat.GetAll().ToList();

        foreach (var item in typeBoatList)
        {
            if (item.Name == typeBoat.Name)
            {
                ModelState.AddModelError("Name", "Name vec postoji");
            }
            if (item.DisplayOrder == typeBoat.DisplayOrder)
            {
                ModelState.AddModelError("DisplayOrder", "Display order vec postoji");
            }
        }

        if (ModelState.IsValid)
        {

            _unitOfWork.TypeOfBoat.Add(typeBoat);
            _unitOfWork.Save();  //potrebno da je se spremi na bazu
            TempData["success"] = "Uspijeh";
            return RedirectToAction("Index", "Category");
        }

        return View();
    }

    public IActionResult Edit(int? typeBoatId)
    {
        if (typeBoatId == null && typeBoatId == 0)
        {
            return NotFound();
        }
        TypeBoat? typeBoat = _unitOfWork.TypeOfBoat.Get(c => c.Id == typeBoatId);

        if (typeBoat == null)
        {
            return NotFound();
        }
        return View(typeBoat);
    }

    [HttpPost]
    public IActionResult Edit(TypeBoat typeBoat)
    {

        if (ModelState.IsValid)
        {

            _unitOfWork.TypeOfBoat.Update(typeBoat);
            _unitOfWork.Save();  //potrebno da je se spremi na bazu
            TempData["success"] = "Category edited successfully";
            return RedirectToAction("Index", "Category");
        }

        return View();
    }
    
    public IActionResult Delete(int? typeBoatId)
    {
        if (typeBoatId == null && typeBoatId == 0)
        {
            return NotFound();
        }
        TypeBoat? typeBoat = _unitOfWork.TypeOfBoat.Get(c => c.Id == typeBoatId);

        if (typeBoat == null)
        {
            return NotFound();
        }
        return View(typeBoat);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(int? typeBoatId)
    {
        TypeBoat? typeBoat = _unitOfWork.TypeOfBoat.Get(c => c.Id == typeBoatId);

        if (typeBoat == null)
        {
            return NotFound();
        }
        _unitOfWork.TypeOfBoat.Delete(typeBoat);
        _unitOfWork.Save();
        TempData["success"] = "Category deleted successfully";

        return RedirectToAction("Index", "Category");
    }
}
