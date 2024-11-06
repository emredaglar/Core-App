using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager _testimonialManager=new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = _testimonialManager.TGetList();
            return View(values);
        }
    }
}
