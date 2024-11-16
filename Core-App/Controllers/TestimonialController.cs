using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = _testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values= _testimonialManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            _testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialManager.TGetByID(id);
            _testimonialManager.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
