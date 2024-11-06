using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager=new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values=featureManager.TGetList();
            return View(values);
        }
    }
}
