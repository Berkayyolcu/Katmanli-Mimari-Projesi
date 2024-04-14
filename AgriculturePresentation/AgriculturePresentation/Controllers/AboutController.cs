using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About socialMedia)
        {
            _aboutService.Insert(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.GetById(id);
            _aboutService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About socialMedia)
        {
            _aboutService.Update(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
