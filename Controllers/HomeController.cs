
using BuilderDesignPatternDemo.Models;
using BuilderDesignPatternDemo.Services;

using Microsoft.AspNetCore.Mvc;

namespace BuilderDesignPatternDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanDirector _director;

        public HomeController(IPlanDirector director)
        {
            _director = director;
        }

        public IActionResult Index()
        {
            PricingPlansModel model = new PricingPlansModel();

            // Build Basic Plan

            var basicPlanBuilder = new BasicPlanBuilder();
            _director.SetPlanBuilder(basicPlanBuilder);
            _director.BuildBasicPlan();
            model.BasicPlan = basicPlanBuilder.GetPlan();

            // Build Enterprise Plan 

            var enterprisePlanBuilder = new EnterprisePlanBuilder();
            _director.SetPlanBuilder(enterprisePlanBuilder);
            _director.BuildEnterprisePlan();
            model.EnterprisePlan = enterprisePlanBuilder.GetPlan();


            // Build Custom Plan 

            var customPlanBuilder = new BasicPlanBuilder();
            customPlanBuilder.BuildDiskSpaceFeature();
            customPlanBuilder.BuildBandwidthFeature();
            model.CustomPlan = customPlanBuilder.GetPlan();

            return View(model);
        }
    }
}
