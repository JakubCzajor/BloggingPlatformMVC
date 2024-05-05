using BloggingPlatform.Models;
using BloggingPlatform.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    public class PostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var postList = _unitOfWork.Post.GetAll().ToList();
            return View(postList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Post.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Post created successfully.";
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}
