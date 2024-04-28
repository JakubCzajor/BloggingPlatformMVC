using BloggingPlatform.Models;
using BloggingPlatform.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var categoryList = _unitOfWork.Category.GetAll().ToList();
            return View(categoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully.";
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var categoryObj = _unitOfWork.Category.Get(id);

            if (categoryObj is null)
            {
                return NotFound();
            }

            return View(categoryObj);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully.";
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
