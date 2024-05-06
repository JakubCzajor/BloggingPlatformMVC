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
        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                return View(new Post());
            }
 
            var postObj = _unitOfWork.Post.Get(id);
            return View(postObj);
        }

        [HttpPost]
        public IActionResult Upsert(Post obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Id == 0)
                {
                    _unitOfWork.Post.Add(obj);
                    TempData["success"] = "Post created successfully.";
                }
                else
                {
                    _unitOfWork.Post.Update(obj);
                    TempData["success"] = "Post updated successfully.";
                }

                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(new Post());
        }
    }
}
